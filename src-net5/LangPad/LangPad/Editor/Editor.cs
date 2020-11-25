using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace LangPad.Editor
{
    public class Editor : WebView2
    {
        public static string EditorHtmlFile => Path.Combine(App.DataFolder, "editor.html");

        public Editor() : base()
        {
            EnsureCoreWebView2Async();
            CoreWebView2Ready += Editor_CoreWebView2Ready;

            // Create editor HTML if it doesn't already exist
            if(!File.Exists(EditorHtmlFile))
            {
                var editorHtml = ResourceReader.Get("LangPad.Resources.Editor.editor.html");
                var styles = new List<string> {
                    ResourceReader.Get("LangPad.Resources.Editor.lib.codemirror.css"),
                    ResourceReader.Get("LangPad.Resources.Editor.lib.theme.ttcn.css"),
                    ResourceReader.Get("LangPad.Resources.Editor.editor.css")
                };
                var scripts = new List<string> {
                    ResourceReader.Get("LangPad.Resources.Editor.lib.codemirror.js"),
                    ResourceReader.Get("LangPad.Resources.Editor.lib.mode.css.css.js"),
                    ResourceReader.Get("LangPad.Resources.Editor.lib.mode.javascript.javascript.js"),
                    ResourceReader.Get("LangPad.Resources.Editor.lib.mode.xml.xml.js"),
                    ResourceReader.Get("LangPad.Resources.Editor.lib.mode.htmlmixed.htmlmixed.js"),
                    ResourceReader.Get("LangPad.Resources.Editor.editor.js")
                };
                editorHtml = Renderer.RenderStyles(editorHtml, "Styles", styles);
                editorHtml = Renderer.RenderScripts(editorHtml, "Scripts", scripts);

                File.WriteAllText(EditorHtmlFile, editorHtml);
            }
        }

        private void Editor_CoreWebView2Ready(object sender, EventArgs e)
        {
#if DEBUG
            // Show dev tools in debug
            CoreWebView2.Settings.AreDefaultContextMenusEnabled = true;
            CoreWebView2.Settings.AreDevToolsEnabled = true;
            CoreWebView2.Settings.IsZoomControlEnabled = true;
#endif

            // Load editor into web view
            CoreWebView2.Navigate(EditorHtmlFile);
        }
    }
}
