using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Xml.Linq;

namespace Language_Pad
{
    public partial class CharacterEditor
    {
        public Func<TextBoxBase> GetCurrentTexbox;
        public string Character { get; set; }
        private List<string> AccentsList = new List<string>();
        private string AccentsString = "";
        private void UpdateResult()
        {
            if (txtCharacter.Text == "")
            {
                btnCharacter.Text = "";
                return;
            }

            if (cbSmartReplace.Checked)
            {
                string result = txtCharacter.Text + AccentsString; // 
                pnlSmartReplace.BackColor = Color.DimGray;

                foreach (KeyValuePair<string, string> pair in LanguagePadCommon.SmartReplaceList)
                {
                    result = result.Replace(pair.Key, pair.Value);

                    if (result.Contains(pair.Value))
                        pnlSmartReplace.BackColor = Color.LimeGreen;
                }

                btnCharacter.Text = result;
            }
            else
                btnCharacter.Text = txtCharacter.Text + AccentsString;
        }

        private void ToggleAccent(object sender, EventArgs e)
        {
            AccentCheckButton button = (AccentCheckButton)sender;

            if ((button.Checked))
                AccentsList.Add(button.Text.Replace("◌", ""));
            else
                AccentsList.Remove(button.Text.Replace("◌", ""));

            AccentsString = "";
            foreach (string accent in AccentsList)
                AccentsString += accent;

            UpdateResult();
        }

        public static void AddToLocal()
        {
        }

        public void InsertCharacterButton(string Text, FlowLayoutPanel Panel)
        {
            CharacterButton SymbolButton = new CharacterButton();
            SymbolButton.Text = Text;
            SymbolButton.Click += CharacterButtonClick;
            Panel.Controls.Add(SymbolButton);
        }

        public void InsertAccentButton(string Text)
        {
            AccentCheckButton AccentButton = new AccentCheckButton()
            {
                Text = "◌" + Text,
                Font = new Font("Calibri", 18, FontStyle.Regular),
                Margin = new Padding(1),
                Padding = new Padding(0),
                MinimumSize = new Size(45, 45)
            };
            AccentButton.Click += ToggleAccent;
            AccentsLayoutPanel.Controls.Add(AccentButton);
        }

        public void CharacterButtonClick(object sender, EventArgs e)
        {
            Button Button = (Button)sender;
            InsertText(GetCurrentTexbox(), Button.Text);
        }

        public void InsertText(TextBoxBase TextBox, string Text)
        {
            ;/* Cannot convert OnErrorResumeNextStatementSyntax, CONVERSION ERROR: Conversion for OnErrorResumeNextStatement not implemented, please report this issue in 'On Error Resume Next' at character 3911
   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.DefaultVisit(SyntaxNode node)
   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitOnErrorResumeNextStatement(OnErrorResumeNextStatementSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.OnErrorResumeNextStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

Input: 
        On Error Resume Next

 */
            int CurrentPos = TextBox.SelectionStart;
            object obj = Clipboard.GetDataObject();
            Clipboard.SetText(Text);
            TextBox.Paste();
            Clipboard.SetDataObject(obj);

            TextBox.Focus();
            TextBox.SelectionStart = CurrentPos + Text.Length;
            TextBox.SelectionLength = 0;
        }

        private void CharacterEditor_Load(object sender, EventArgs e)
        {
            if (Character == "")
                Character = "a";
            txtCharacter.Text = Character;

            cbSmartReplace.Visible = My.MySettingsProperty.Settings.SmartReplace;
            AccentsList.Clear();
            AccentsString = "";
            UpdateResult();
        }

        private void TxtCharacter_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }
    }
}
