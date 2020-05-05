namespace LangPadUI
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
            this.shortcutKeyLabel = new System.Windows.Forms.Label();
            this.charButton = new LangPadUI.CharacterButton();
            this.separatorMain = new LangPadUI.DoubleBufferedPanel();
            this.SuspendLayout();
            // 
            // shortcutKeyLabel
            // 
            this.shortcutKeyLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shortcutKeyLabel.Location = new System.Drawing.Point(4, 83);
            this.shortcutKeyLabel.Margin = new System.Windows.Forms.Padding(4);
            this.shortcutKeyLabel.Name = "shortcutKeyLabel";
            this.shortcutKeyLabel.Size = new System.Drawing.Size(82, 23);
            this.shortcutKeyLabel.TabIndex = 1;
            this.shortcutKeyLabel.Text = "CTRL+0";
            this.shortcutKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charButton
            // 
            this.charButton.AutoSize = true;
            this.charButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.charButton.BackColor = System.Drawing.Color.Transparent;
            this.charButton.CharName = "";
            this.charButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charButton.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.charButton.ForeColor = System.Drawing.Color.Black;
            this.charButton.Location = new System.Drawing.Point(4, 4);
            this.charButton.Margin = new System.Windows.Forms.Padding(4);
            this.charButton.MinimumSize = new System.Drawing.Size(45, 45);
            this.charButton.Multiline = true;
            this.charButton.Name = "charButton";
            this.charButton.Size = new System.Drawing.Size(82, 74);
            this.charButton.TabIndex = 0;
            this.charButton.Text = "a";
            this.charButton.UseCompatibleTextRendering = true;
            this.charButton.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.charButton);
            this.Controls.Add(this.separatorMain);
            this.Controls.Add(this.shortcutKeyLabel);
            this.Name = "ShortcutButton";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(90, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CharacterButton charButton;
        private System.Windows.Forms.Label shortcutKeyLabel;
        private DoubleBufferedPanel separatorMain;
    }
}
