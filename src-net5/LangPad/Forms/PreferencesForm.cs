using Eto.Drawing;
using Eto.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangPad.Forms
{
    public class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            Title = "Preferences";
            ClientSize = new Size(600, 400);
            Resizable = false;
            Maximizable = false;
            Minimizable = false;
        }
    }
}
