namespace LangPad.Controls
{
    partial class ShortcutButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShortcutKeyLabel = new System.Windows.Forms.Label();
            this.CharButton = new LangPad.Controls.CharacterButton();
            this.separatorMain = new LangPad.Controls.DoubleBufferedPanel();
            this.SuspendLayout();
            // 
            // ShortcutKeyLabel
            // 
            this.ShortcutKeyLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShortcutKeyLabel.Location = new System.Drawing.Point(4, 83);
            this.ShortcutKeyLabel.Margin = new System.Windows.Forms.Padding(4);
            this.ShortcutKeyLabel.Name = "ShortcutKeyLabel";
            this.ShortcutKeyLabel.Size = new System.Drawing.Size(82, 23);
            this.ShortcutKeyLabel.TabIndex = 1;
            this.ShortcutKeyLabel.Text = "CTRL+0";
            this.ShortcutKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharButton
            // 
            this.CharButton.AutoSize = true;
            this.CharButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CharButton.BackColor = System.Drawing.Color.Transparent;
            this.CharButton.CharName = "";
            this.CharButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharButton.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.CharButton.ForeColor = System.Drawing.Color.Black;
            this.CharButton.Location = new System.Drawing.Point(4, 4);
            this.CharButton.Margin = new System.Windows.Forms.Padding(4);
            this.CharButton.MinimumSize = new System.Drawing.Size(45, 45);
            this.CharButton.Multiline = true;
            this.CharButton.Name = "CharButton";
            this.CharButton.Size = new System.Drawing.Size(82, 74);
            this.CharButton.TabIndex = 0;
            this.CharButton.Text = "a";
            this.CharButton.UseCompatibleTextRendering = true;
            this.CharButton.UseVisualStyleBackColor = false;
            // 
            // separatorMain
            // 
            this.separatorMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorMain.Location = new System.Drawing.Point(4, 78);
            this.separatorMain.Name = "separatorMain";
            this.separatorMain.Size = new System.Drawing.Size(82, 5);
            this.separatorMain.TabIndex = 2;
            // 
            // ShortcutButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CharButton);
            this.Controls.Add(this.separatorMain);
            this.Controls.Add(this.ShortcutKeyLabel);
            this.Name = "ShortcutButton";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(90, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ShortcutKeyLabel;
        private DoubleBufferedPanel separatorMain;
        public CharacterButton CharButton;
    }
}
