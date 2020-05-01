using System.Windows.Forms;

namespace LangPadUI
{
    public class FixedSR : ToolStripSystemRenderer
    {
        /// <summary>
        /// Prevent the default renderer from rendering its own decorations
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
        }
    }
}
