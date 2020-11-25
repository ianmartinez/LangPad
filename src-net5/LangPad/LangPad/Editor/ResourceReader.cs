using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace LangPad.Editor
{
    public static class ResourceReader
    {
        public static string Get(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceStream = assembly.GetManifestResourceStream(name);
            using var reader = new StreamReader(resourceStream);
            return reader.ReadToEnd();
        }
    }
}
