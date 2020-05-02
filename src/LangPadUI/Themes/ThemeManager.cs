using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LangPadUI.Themes
{
    public class ThemeManager
    {
        private Theme theme;

        public Theme CurrentTheme
        {
            get
            {
                return theme;
            }

            set
            {
                theme = value;
                RefreshTheme();
            }
        }

        public List<Theme> Themes { get; set; }

        private readonly List<ToolStrip> menuList = new List<ToolStrip>();
        private readonly List<ToolStrip> contextMenuList = new List<ToolStrip>();
        private readonly List<ToolStripContainer> toolStripContainerList = new List<ToolStripContainer>();
        private readonly List<ToolStrip> toolStripList = new List<ToolStrip>();
        private readonly List<Control> panelList = new List<Control>();

        private void RefreshTheme()
        {
            foreach (var menu in menuList)
            {
                menu.Renderer = CurrentTheme.MenuRenderer;
                menu.Invalidate();
            }

            foreach (var contextMenu in contextMenuList)
            {
                contextMenu.Renderer = CurrentTheme.MenuRenderer;
                contextMenu.Invalidate();
            }

            foreach (var toolStrip in toolStripList)
            {
                toolStrip.Renderer = CurrentTheme.ToolStripRenderer;
                toolStrip.Invalidate();
            }

            foreach (var panel in panelList)
            {
                panel.BackColor = theme.PanelBackColor;
                panel.ForeColor = theme.PanelTextColor;
            }
        }

        public void AddMenu(params MenuStrip[] menus)
        {
            foreach (var menu in menus)
            {
                menuList.Add(menu);
            }
        }

        public void AddContextMenu(params ContextMenuStrip[] contextMenus)
        {
            foreach (var menu in contextMenus)
            {
                contextMenuList.Add(menu);
            }
        }

        public void AddToolStripContainer(params ToolStripContainer[] containers)
        {
            foreach (var container in containers)
            {
                toolStripContainerList.Add(container);
                container.TopToolStripPanel.Paint += RenderToolStripPanel;
                container.BottomToolStripPanel.Paint += RenderToolStripPanel;
                container.LeftToolStripPanel.Paint += RenderToolStripPanel;
                container.RightToolStripPanel.Paint += RenderToolStripPanel;
            }
        }

        public void AddToolStrip(params ToolStrip[] toolStrips)
        {
            foreach (var toolStrip in toolStrips)
            {
                toolStripList.Add(toolStrip);
            }
        }

        public void AddPanel(params Control[] panels)
        {
            foreach (var panel in panels)
            {
                panelList.Add(panel);
            }
        }

        public void RenderToolStripPanel(object sender, PaintEventArgs e)
        {
            var container = (ToolStripContainer)(sender as ToolStripPanel).Parent;
            var rect = new Rectangle(0, 0, container.Width, container.Height);
            var gradientMode = CurrentTheme.HasVerticalMenuGradient ? LinearGradientMode.Vertical : LinearGradientMode.Horizontal;
            var background = new LinearGradientBrush(rect, CurrentTheme.PanelBackColor, CurrentTheme.PanelBackColor, gradientMode);
            e.Graphics.FillRectangle(background, rect);
        }

        public void HandleToolStripPanelSizeChange(object sender, PaintEventArgs e)
        {
            var container = (ToolStripContainer)(sender as ToolStripPanel).Parent;
            container.Invalidate();
        }
    }
}
