using System;

namespace LangPadData;

/// <summary>
/// Static class with common functions dealing with lines in strings.
/// </summary>
public static class Lines
{

    /// <summary>
    /// Get an array of lines a string, removing empty lines.
    /// </summary>
    /// 
    /// <param name="data">The string to get the lines from.</param>
    /// 
    /// <returns>The array of non-empty lines in the string.</returns>
    public static string[] Get(string data) => data.Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
}
