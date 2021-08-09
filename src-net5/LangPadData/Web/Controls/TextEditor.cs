using LangPadData.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LangPadData.Web.Controls
{
    public enum TextEditTheme
    {
        Light,
        Dark,
        SolarizedLight,
        SolarizedDark
    }

    /*
     * A wrapper for a text edit instance hosted inside a web view
     * managed by ViewManager. Handles dealing with all interop between
     * the js side and the c# side.
     */
    public class TextEditor
    {
        private readonly IWebViewManager ViewManager;
        private readonly IWebViewManager PreviewViewManager;
        private Timer PreviewTimer;
        public event EventHandler<EventArgs> ContentChanged;

        public TextEditor(IWebViewManager viewManager, IWebViewManager previewViewManager = null)
        {
            ViewManager = viewManager;
            PreviewViewManager = previewViewManager;

            LoadTextEditDocument();

            if (previewViewManager != null)
                LoadPreview();
        }

        private TextEditTheme _theme;
        public TextEditTheme Theme
        {
            get
            {
                return _theme;
            }

            set
            {
                _theme = value;
                ViewManager.RunScript(string.Format("setEditorTheme('{0}');", _theme.ToString()));
            }
        }

        public string Content
        {
            get
            {
                return ViewManager.RunScript("return getEditorContent();");
            }

            set
            {
                var safeValue = MakeSafe(value);
                ViewManager.RunScript(string.Format("setEditorContent('{0}');", safeValue));
                RefreshPreview();
            }
        }

        /**
         * The base document to insert the editor code into before
         * inserting into the PreviewViewManager, if blank just insert
         * the text verbatim.
         */
        public string PreviewBase { get; set; }

        private string MakeSafe(string value)
        {
            var encodedValue = value.Replace("\n", "\\n");
            encodedValue = encodedValue.Replace("\r", "\\r");
            encodedValue = encodedValue.Replace("'", "\\'");
            return encodedValue;
        }

        private string lastPreview = "";
        public void RefreshPreview()
        {
            var newPreview = Content;
            // Check if the the content is different from the old content
            if (!lastPreview.Equals(newPreview))
            {
                // Trigger ContentChangedEvent
                var eventArgs = new EventArgs();
                ContentChanged(this, eventArgs);

                // If there is a preview that needs updating
                if (PreviewViewManager != null)
                {
                    /*
                     * Store the preview content that is being set so that the
                     * preview doesn't constantly refresh when it doesn't have
                     * to
                     */
                    lastPreview = newPreview;

                    if (!string.IsNullOrEmpty(PreviewBase))
                    {
                        PreviewViewManager.Content = PreviewBase.Replace("{Content}", newPreview);
                    }
                    else
                    {
                        PreviewViewManager.Content = newPreview;
                    }
                }
            }
        }

        private void LoadTextEditDocument()
        {
            string html = Resources.TextEditorHtml;
            html = HtmlRenderer.RenderStyle(html, "CodeMirrorStyle", Resources.CodeMirrorCss);
            html = HtmlRenderer.RenderScript(html, "CodeMirrorScript", Resources.CodeMirrorJs);

            html = HtmlRenderer.RenderScript(html, "CodeMirrorModeCss", Resources.ModeCss);
            html = HtmlRenderer.RenderScript(html, "CodeMirrorModeXml", Resources.ModeXml);
            html = HtmlRenderer.RenderScript(html, "CodeMirrorModeJs", Resources.ModeJavaScript);
            html = HtmlRenderer.RenderScript(html, "CodeMirrorModeHtmlMixed", Resources.ModeHtmlMixed);

            html = HtmlRenderer.RenderStyle(html, "TextEditStyle", Resources.TextEditorCss);
            html = HtmlRenderer.RenderScript(html, "TextEditScript", Resources.TextEditorJs);

            html = HtmlRenderer.RenderStyle(html, "CodeMirrorTheme", Resources.ttcn);

            ViewManager.Content = html;
        }

        private void LoadPreview()
        {
            // Refresh the preview every .5 seconds
            PreviewTimer = new Timer(500);
            PreviewTimer.Elapsed += (sender, e) => RefreshPreview();
            PreviewTimer.Start();
        }
    }
}
