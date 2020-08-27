using System;
using System.Collections.Generic;
using System.IO;

namespace LangPadData
{
    public static class Config
    {
        private static string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string AppFolder = Path.Combine(AppData, "LangPad");
        private static string SettingsFilePath = Path.Combine(AppFolder, "LangPad.config");
        private static Dictionary<string, string> Settings; 

        public static bool HasLoaded => Settings != null;

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
            var lines = new List<KvLine>();
            lines.Add(new KvLine(KvLineType.Comment, "LangPad Configuration"));

            foreach (var setting in Settings)
                lines.Add(new KvLine(KvLineType.KeyValue, setting.Key, setting.Value));

            KeyValue.WriteFile(SettingsFilePath, lines);
        }

        public static string Test
        {
            get => KeyValue.Search(Settings, "Test", "testvalue");
            set
            {
                Settings["Test"] = value;
                SaveSettingsFile();
            }
        }
    }
}
