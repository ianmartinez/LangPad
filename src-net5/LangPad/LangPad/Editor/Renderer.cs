using System;
using System.Collections.Generic;
using System.Text;

namespace LangPad.Editor
{
    public static class Renderer
    {
        public static string Render(string html, string name, string value)
        {
            return html.Replace("{{" + name + "}}", value);
        }
        public static string Render(string html, string name, List<string> values)
        {
            return html.Replace("{{" + name + "}}", string.Join("\n", values));
        }

        public static string RenderTag(string html, string tag, string name, string value = "")
        {
            return Render(html, name, string.Format("<{0}>{1}</{0}>", tag, value));
        }

        public static string RenderScript(string html, string name, string value)
        {
            return RenderTag(html, "script", name, value);
        }

        public static string RenderScripts(string html, string name, List<string> value)
        {
            return RenderTag(html, "script", name, string.Join("\n", value));
        }

        public static string RenderStyle(string html, string name, string value)
        {
            return RenderTag(html, "style", name, value);
        }
        public static string RenderStyles(string html, string name, List<string> value)
        {
            return RenderTag(html, "style", name, string.Join("\n", value));
        }
    }
}
