using System;
using System.Collections.Generic;
using System.IO;

namespace LangPadData
{

    public static class KeyValue
    {
        public static Dictionary<string, string> Read(string data)
        {
            var lines = Lines.Get(data);
            var kvList = new Dictionary<string, string>();

            foreach (var line in lines)
            {
                // Skip if comment or invalid
                if (line.StartsWith("!") || line.StartsWith("#") || !line.Contains("="))
                    continue;

                kvList.Add(UnformatString(line.Split('=')[0]), UnformatString(line.Split('=')[1]));
            }

            return kvList;
        }

        public static Dictionary<string, string> ReadFile(string filePath)
        {
            return Read(File.ReadAllText(filePath));
        }

        public static string Write(List<KvLine> lines, bool makeCompatible = true)
        {
            var result = "";

            foreach (var line in lines)
            {
                string formattedValue = (makeCompatible) ? FormatString(line.Value) : line.Value;

                if (line.LineType == KvLineType.Comment)
                    result = result.Insert(result.Length, string.Format("#{0}", line.Key));
                else if (line.LineType == KvLineType.KeyValue)
                    result = result.Insert(result.Length, string.Format("{0}={1}", line.Key, formattedValue));

                result = result.Insert(result.Length, Environment.NewLine);
            }

            return result;
        }

        public static void WriteFile(string filePath, List<KvLine> lines, bool makeCompatible = true)
        {
            File.WriteAllText(filePath, Write(lines, makeCompatible));
        }

        public static string Search(Dictionary<string, string> data, string key)
        {
            return data.ContainsKey(key) ? data[key] : "";
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

    public enum KvLineType
    {
        Comment,
        KeyValue,
        Blank
    }

    public struct KvLine
    {
        public KvLineType LineType;
        public string Key;
        public string Value;

        public KvLine(KvLineType lineType, string key = "", string value = "")
        {
            LineType = lineType;
            Key = key;
            Value = value;
        }
    }

}
