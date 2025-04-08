using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace LangPadData;

public static class Config
{
    private static readonly string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    private static readonly string AppFolder = Path.Combine(AppData, "LangPad");
    private static readonly string SettingsFilePath = Path.Combine(AppFolder, "LangPad.config");
    private static Dictionary<string, string> Settings;
    public static bool HasLoaded => Settings != null;

    private static string GetKey(string key, string fallback = "")
    {
        if (!HasLoaded)
            LoadSettingsFile();

        return KeyValue.Search(Settings, key, fallback);
    }

    public static void LoadSettingsFile()
    {
        // Create config folder, if it doesn't exist
        if (!Directory.Exists(AppFolder))
            Directory.CreateDirectory(AppFolder);

        // Create settings file, if it doesn't exist
        if (!File.Exists(SettingsFilePath))
            File.WriteAllText(SettingsFilePath, "");

        // Load settings
        Settings = KeyValue.ReadFile(SettingsFilePath);
    }

    public static void SaveSettingsFile()
    {
        List<KvLine> lines = [new(KvLineType.Comment, "LangPad Configuration")];
        foreach (var setting in Settings)
            lines.Add(new KvLine(KvLineType.KeyValue, setting.Key, setting.Value));
        KeyValue.WriteFile(SettingsFilePath, lines);
    }

    #region "Local Characters"
    /// <summary>
    /// The local characters string.
    /// </summary>
    public static string LocalCharsString
    {
        get => GetKey("LocalCharacters");
        set
        {
            Settings["LocalCharacters"] = value;
            SaveSettingsFile();
        }
    }

    /// <summary>
    /// The local characters as a list.
    /// </summary>
    public static List<string> LocalChars => [.. Lines.Get(LocalCharsString)];

    /// <summary>
    /// Add a character to the local characters.
    /// </summary>
    public static void AddLocalCharacter(string character)
    {
        var charList = LocalChars;
        if (!charList.Contains(character))
            charList.Add(character);

        LocalCharsString = string.Join("\n", charList);
    }

    /// <summary>
    /// Remove a character from the local characters.
    /// </summary>
    public static void RemoveLocalCharacter(string character)
    {
        var charList = LocalChars;
        charList.Remove(character);

        LocalCharsString = string.Join("\n", charList);
    }

    /// <summary>
    /// Remove all local characters.
    /// </summary>
    public static void ClearLocalCharacters()
    {
        LocalCharsString = "";
    }
    #endregion

    #region "Settings"
    /// <summary>
    /// If the app will search for updates at startup.
    /// </summary>
    public static bool UpdateOnStartup
    {
        get => bool.Parse(GetKey("Updates", "true"));
        set
        {
            Settings["Updates"] = value.ToString();
            SaveSettingsFile();
        }
    }

    /// <summary>
    /// The app's theme.
    /// </summary>
    public static string Theme
    {
        get => GetKey("Theme");
        set
        {
            Settings["Theme"] = value;
            SaveSettingsFile();
        }
    }

    /// <summary>
    /// If smart replace is enabled.
    /// </summary>
    public static bool SmartReplace
    {
        get => bool.Parse(GetKey("SmartReplace", "true"));
        set
        {
            Settings["SmartReplace"] = value.ToString();
            SaveSettingsFile();
        }
    }

    /// <summary>
    /// If HiDPI is to be used.
    /// </summary>
    public static bool HiDPI
    {
        get => bool.Parse(GetKey("HiDPI", "false"));
        set
        {
            Settings["HiDPI"] = value.ToString();
            SaveSettingsFile();
        }
    }

    /// <summary>
    /// If the character editor window should open automatically
    /// at startup.
    /// </summary>
    public static bool ShowCharacterEditorOnStartup
    {
        get => bool.Parse(GetKey("ShowCharacterEditorOnStartup", "true"));
        set
        {
            Settings["ShowCharacterEditorOnStartup"] = value.ToString();
            SaveSettingsFile();
        }
    }

    /// <summary>
    /// The default size of the font on dictionary tables.
    /// </summary>
    public const int DefaultDictionaryFontSize = 10;

    /// <summary>
    /// The size of the font on dictionary tables.
    /// </summary>
    public static int DictionaryFontSize
    {
        get => int.Parse(GetKey("DictionaryFontSize", DefaultDictionaryFontSize.ToString()));
        set
        {
            Settings["DictionaryFontSize"] = value.ToString();
            SaveSettingsFile();
        }
    }
    #endregion

    #region "Shortcuts"    
    public static PropertyInfo GetProperty(string name) => typeof(Config).GetProperty(name, BindingFlags.Public | BindingFlags.Static);

    public static string Ctrl0
    {
        get => GetKey("Ctrl0");
        set
        {
            Settings["Ctrl0"] = value;
            SaveSettingsFile();
        }
    }

    public static string Ctrl1
    {
        get => GetKey("Ctrl1");
        set
        {
            Settings["Ctrl1"] = value;
            SaveSettingsFile();
        }
    }

    public static string Ctrl2
    {
        get => GetKey("Ctrl2");
        set
        {
            Settings["Ctrl2"] = value;
            SaveSettingsFile();
        }
    }

    public static string Ctrl3
    {
        get => GetKey("Ctrl3");
        set
        {
            Settings["Ctrl3"] = value;
            SaveSettingsFile();
        }
    }

    public static string Ctrl4
    {
        get => GetKey("Ctrl4");
        set
        {
            Settings["Ctrl4"] = value;
            SaveSettingsFile();
        }
    }

    public static string Ctrl5
    {
        get => GetKey("Ctrl5");
        set
        {
            Settings["Ctrl5"] = value;
            SaveSettingsFile();
        }
    }

    public static string Ctrl6
    {
        get => GetKey("Ctrl6");
        set
        {
            Settings["Ctrl6"] = value;
            SaveSettingsFile();
        }
    }

    public static string Ctrl7
    {
        get => GetKey("Ctrl7");
        set
        {
            Settings["Ctrl7"] = value;
            SaveSettingsFile();
        }
    }

    public static string Ctrl8
    {
        get => GetKey("Ctrl8");
        set
        {
            Settings["Ctrl8"] = value;
            SaveSettingsFile();
        }
    }

    public static string Ctrl9
    {
        get => GetKey("Ctrl9");
        set
        {
            Settings["Ctrl9"] = value;
            SaveSettingsFile();
        }
    }
    #endregion
}
