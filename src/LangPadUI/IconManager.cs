using System.Drawing;
using System.Reflection;

namespace LangPadUI
{
    /// <summary>
    /// The size of the icon.
    /// </summary>
    public enum IconSize
    {
        Small, Large
    }

    /// <summary>
    /// The resolution of the display.
    /// </summary>
    public enum IconResolution
    {
        Normal, HiDPI
    }

    /// <summary>
    /// Get icons from the resources of this library.
    /// </summary>
    public static class IconManager
    {
        /// <summary>
        /// Get an icon with a given name and size from the icons stored as resources
        /// in this library.
        /// </summary>
        /// 
        /// <param name="name">The name of the icon.</param>
        /// <param name="iconSize">The size of the icon.</param>
        /// <param name="iconResolution">The screen resolution to match the icons with.</param>
        /// <returns></returns>
        public static Bitmap Get(string name, IconSize iconSize, IconResolution iconResolution)
        {
            string folder;

            if (iconResolution == IconResolution.Normal)
                folder = (iconSize == IconSize.Large) ? "Icon32" : "Icon24";
            else
                folder = (iconSize == IconSize.Large) ? "Icon48" : "Icon32";

            var resourceName = string.Format("LangPadUI.Resources.{0}.{1}.png", folder, name);
            var assembly = Assembly.GetExecutingAssembly();
            // Find what files are available:
            // var names = assembly.GetManifestResourceNames().Where(n => n.Contains(".Icon48.")).ToArray();
            var s = assembly.GetManifestResourceStream(resourceName);
            return new Bitmap(s);
        }
    }
}
