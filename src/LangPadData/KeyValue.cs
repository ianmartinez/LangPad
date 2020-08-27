using System;
using System.Collections.Generic;
using System.IO;

namespace LangPadData
{
    /// <summary>
    /// Read from Key/Value files, which are basically just INI files
    /// without sections (i.e. '[section]' syntax).
    /// 
    /// Comments are supported for lines that begin with "#" or "!".
    /// 
    /// Escape characters are:
    /// :eq: for '='
    /// :pi: for '|'
    /// :co: for ','
    /// :cr: for Environment.NewLine
    /// </summary>
    public static class KeyValue
    {
        /// <summary>
        /// Read from a string and produce a dictionary of keys and values.
        /// </summary>
        /// 
        /// <param name="data">The key/value data string.</param>
        /// 
        /// <returns>A dictionary of keys and values.</returns>
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

        /// <summary>
        /// Read from a file and produce a dictionary of keys and values.
        /// </summary>
        /// 
        /// <param name="filePath">The pathe to the key/value data file.</param>
        /// 
        /// <returns>A dictionary of keys and values.</returns>
        public static Dictionary<string, string> ReadFile(string filePath)
        {
            return Read(File.ReadAllText(filePath));
        }

        /// <summary>
        /// Write a list of key/value lines to a string.
        /// </summary>
        /// 
        /// <param name="lines">The lines to write to the string.</param>
        /// <param name="makeCompatible">If the value should be sanitized using FormatString() before 
        /// writing to the string.</param>
        /// 
        /// <returns>The string containing all of the key/value data.</returns>
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

        /// <summary>
        /// Write a list of key/value lines to a text file.
        /// </summary>
        /// 
        /// <param name="filePath">The path of the text file to write to.</param>
        /// <param name="lines">The lines to write to the file.</param>
        /// <param name="makeCompatible">If the value should be sanitized using FormatString() before 
        /// writing to the file.</param>
        public static void WriteFile(string filePath, List<KvLine> lines, bool makeCompatible = true)
        {
            File.WriteAllText(filePath, Write(lines, makeCompatible));
        }

        /// <summary>
        /// Get the value from a key/value dictionary by key. Returns
        /// String.Empty if nothing was found.
        /// </summary>
        /// 
        /// <param name="data">The key/value dictionary.</param>
        /// <param name="key">The key to search for.</param>
        /// <param name="fallback">The fallback value if the key was not found.</param>
        /// 
        /// <returns>The value matching the key.</returns>
        public static string Search(Dictionary<string, string> data, string key, string fallback = "")
        {
            return data.ContainsKey(key) ? data[key] : fallback;
        }

        /// <summary>
        /// Get the value from a string of key/value dat by key. Returns
        /// String.Empty if nothing was found.
        /// </summary>
        /// 
        /// <param name="data">The key/value string.</param>
        /// <param name="key">The key to search for.</param>
        /// 
        /// <returns>The value matching the key.</returns>
        public static string GetValue(string data, string key)
        {
            return Search(Read(data), key);
        }

        /// <summary>
        /// Sanitize text so that it can be used as a key or value
        /// in in a key/value file.
        /// </summary>
        /// 
        /// <param name="text">The text to sanitize.</param>
        /// 
        /// <returns>The sanitized text.</returns>
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

        /// <summary>
        /// Unsanitize text that has been sanitized using the FormatString()
        /// function to read keys and values from a key/value file.
        /// </summary>
        /// 
        /// <param name="text">The text to unsanitize.</param>
        /// 
        /// <returns>The unsanitized text.</returns>
        public static string UnformatString(string text)
        {
            text = text.Replace(":eq:", "=");
            text = text.Replace(":pi:", "|");
            text = text.Replace(":co:", ",");
            text = text.Replace(":cr:", Environment.NewLine);
            return text;
        }
    }

    /// <summary>
    /// The type of line in a key/value file.
    /// </summary>
    public enum KvLineType
    {
        Comment, // A line starting with # that will be ignored by the parser
        KeyValue, // A key=value line
        Blank // A line containing no data, just '\n'
    }

    /// <summary>
    /// A line in a key value file.
    /// </summary>
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
