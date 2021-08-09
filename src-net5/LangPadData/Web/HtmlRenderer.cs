using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangPadData.Web
{
    public static class HtmlRenderer
    {
        public static string Render(string html, string name, string value)
        {
            return html.Replace("{" + name + "}", value);
        }

        public static string RenderTag(string html, string tag, string name, string value)
        {
            return Render(html, name, string.Format("<{0}>{1}</{0}>", tag, value));
        }

        public static string RenderScript(string html, string name, string value)
        {
            return RenderTag(html, "script", name, value);
        }

        public static string RenderStyle(string html, string name, string value)
        {
            return RenderTag(html, "style", name, value);
        }
    }
}
