using LangPad.Properties;
using System;
using System.Reflection;

namespace LangPad
{
    public static class AppInfo
    {
        public static Version Version => new Version(0, 1);

        public static string GetFormattedVersion()
        {
            return Version.Major + "." + Version.Minor;
        }

        public static string GetLicense()
        {
            return Resources.License.Replace("{CurrentYear}", DateTime.Now.Year.ToString());
        }
    }
}
