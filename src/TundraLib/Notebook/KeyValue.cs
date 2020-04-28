using System;
using System.Collections.Generic;

namespace ThornWriter.NotebookFile
{
    public static class KeyValue
    {
        public enum LineType
        {
            Comment,
            KeyValue,
            Blank
        }

        public struct Line
        {
            public LineType LineType;
            public string Key;
            public string Value;

            public Line(LineType lineType, string key = "", string value = "")
            {
                LineType = lineType;
                Key = key;
                Value = value;
            }
        }

        public static string[] ToLines(string data)
        {
            return data.Split(new string[] { Environment.NewLine, "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static Dictionary<string, string> Read(string data)
        {
            string[] lines = ToLines(data);
            Dictionary<string, string> kvList = new Dictionary<string, string>();

            foreach (string line in lines)
            {
                // Skip if comment or invalid
                if (line.StartsWith("!") || line.StartsWith("#") || !line.Contains("="))
                    continue;

                kvList.Add(UnformatString(line.Split('=')[0]), UnformatString(line.Split('=')[1]));
            }

            return kvList;
        }

        public static string Write(List<Line> lines, bool makeCompatible = true)
        {
            string result = "";
            foreach (Line line in lines)
            {
                string formattedValue = (makeCompatible) ? FormatString(line.Value) : line.Value;

                if (line.LineType == LineType.Comment)
                    result = result.Insert(result.Length, string.Format("#{0}", line.Key));
                else if (line.LineType == LineType.KeyValue)
                    result = result.Insert(result.Length, string.Format("{0}={1}", line.Key, formattedValue));

                result = result.Insert(result.Length, Environment.NewLine);
            }

            return result;
        }

        public static string Search(Dictionary<string, string> data, string key)
        {
            return data[key] ?? "";
        }

        public static string GetValue(string data, string key)
        {
            return Search(Read(data), key);
        }

        public static string FormatString(string text)
        {
            if (text == null)
                return "";

            text = text.Replace("=", ":eq:");
            text = text.Replace("|", ":pi:");
            text = text.Replace(",", ":co:");
            text = text.Replace(Environment.NewLine, ":cr:");
            text = text.Replace("\r\n", ":cr:");
            text = text.Replace("\n", ":cr:");
            text = text.Replace("\r", ":cr:");
            return text;
        }

        public static string UnformatString(string text)
        {
            text = text.Replace(":eq:", "=");
            text = text.Replace(":pi:", "|");
            text = text.Replace(":co:", ",");
            text = text.Replace(":cr:", Environment.NewLine);
            return text;
        }
    }
}
