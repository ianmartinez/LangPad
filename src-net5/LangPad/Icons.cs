using Eto.Drawing;
using System;
using LangPadData;

namespace LangPad
{
    public static class Icons
    {
        public static Icon Get(string name, IconSize iconSize, IconResolution iconResolution)
        {
            var iconStream = IconManager.Get(name, iconSize, iconResolution);
            return new Icon(iconStream);
        }

        /// <summary>
        /// TODO: Placeholder for icon size settings.
        /// </summary>
        /// <returns></returns>
        public static Icon Get(string name)
        {
            return Get(name, IconSize.Large, IconResolution.Normal);
        }
    }
}
