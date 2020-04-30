using System;
using System.Collections.Generic;
using System.Drawing;

namespace LangPadSupport
{
    public static class ZiaFile
    {
        public enum LineType
        {
            Comment,
            KeyValue,
            Blank
        }

        public struct ZiaLine
        {
            public LineType LineType;
            public string Key;
            public string Value;

            public ZiaLine(LineType lineTpe, string key = "", string value = "")
            {
                LineType = lineTpe;
                Key = key;
                Value = value;
            }
        }

        public static Dictionary<string, string> Read(string data)
        {
            string[] lines = data.Split(new string[] { Environment.NewLine, "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> tempDict = new Dictionary<string, string>();

            foreach (var line in lines)
            {
                var isKvLine = (!line.StartsWith("!") && !line.StartsWith("#") && line.Contains("="));

                if (isKvLine)
                {
                    var lineKv = line.Split('=');
                    tempDict.Add(FromCompatibleStr(lineKv[0]), FromCompatibleStr(lineKv[1]));
                }
            }

            return tempDict;
        }

        public static string Write(List<ZiaLine> sourceLines, bool makeValuesCompatible = false)
        {
            string ziaFile = "";

            foreach (ZiaLine Line in sourceLines)
            {
                if (Line.LineType == LineType.Comment)
                    ziaFile = ziaFile.Insert(ziaFile.Length, string.Format("#{0}", Line.Key));
                else if (Line.LineType == LineType.KeyValue)
                {
                    if (makeValuesCompatible == true)
                        ziaFile = ziaFile.Insert(ziaFile.Length, string.Format("{0}={1}", Line.Key, ToCompatibleStr(Line.Value)));
                    else
                        ziaFile = ziaFile.Insert(ziaFile.Length, string.Format("{0}={1}", Line.Key, Line.Value));
                }

                ziaFile = ziaFile.Insert(ziaFile.Length, Environment.NewLine);
            }

            return ziaFile;
        }

        public static string Search(Dictionary<string, string> data, string lookup)
        {
            return data.ContainsKey(lookup) ? data[lookup] : "";
        }

        public static string ToCompatibleStr(string sourceStr)
        {
            if (sourceStr == null)
                return "";

            sourceStr = sourceStr.Replace("=", ":eq:");
            sourceStr = sourceStr.Replace("|", ":pi:");
            sourceStr = sourceStr.Replace(",", ":co:");
            sourceStr = sourceStr.Replace(Environment.NewLine, ":cr:");
            sourceStr = sourceStr.Replace("\r\n", ":cr:");
            sourceStr = sourceStr.Replace("\n", ":cr:");
            sourceStr = sourceStr.Replace("\r", ":cr:");

            return sourceStr;
        }

        public static string FromCompatibleStr(string sourceStr)
        {
            sourceStr = sourceStr.Replace(":eq:", "=");
            sourceStr = sourceStr.Replace(":pi:", "|");
            sourceStr = sourceStr.Replace(":co:", ",");
            sourceStr = sourceStr.Replace(":cr:", Environment.NewLine);

            return sourceStr;
        }

        public static Color FromCompatibleColor(string sourceStr)
        {
            if (sourceStr.Split(',').Length == 4)
                return Color.FromArgb(int.Parse(sourceStr.Split(',')[0]), int.Parse(sourceStr.Split(',')[1]), int.Parse(sourceStr.Split(',')[2]), int.Parse(sourceStr.Split(',')[3]));
            else if (sourceStr.Split(',').Length == 3)
                return Color.FromArgb(int.Parse(sourceStr.Split(',')[0]), int.Parse(sourceStr.Split(',')[1]), int.Parse(sourceStr.Split(',')[2]));
            else if (sourceStr.StartsWith("#"))
                return ColorTranslator.FromHtml(sourceStr);
            else if (sourceStr.StartsWith("~"))
            {
                int black = int.Parse(sourceStr.Remove(0, 1));
                return Color.FromArgb(black, black, black);
            }
            else if (sourceStr == "$NULL")
                return Color.Transparent;
            else if (sourceStr == "$0")
                return Color.Transparent;
            else if (sourceStr == "$1")
                return Color.White;
            else if (sourceStr == "$2")
                return Color.Black;
            else
                return Color.Transparent;
        }

        public static Font FromCompatibleFont(string sourceStr)
        {
            string _Name = sourceStr.Split('|')[0];
            float _Size = (float.Parse(sourceStr.Split('|')[1]));
            FontStyle _FontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), sourceStr.Split('|')[2]);
            return new Font(_Name, _Size, _FontStyle);
        }
    }
}