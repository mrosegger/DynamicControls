namespace DynamicControls
{
    partial class GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.countElementsOnScreen = new System.Windows.Forms.Label();
            this.selButton = new System.Windows.Forms.RadioButton();
            this.selTextbox = new System.Windows.Forms.RadioButton();
            this.selLabel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // countElementsOnScreen
            // 
            this.countElementsOnScreen.AutoSize = true;
            this.countElementsOnScreen.Location = new System.Drawing.Point(237, 13);
            this.countElementsOnScreen.Name = "countElementsOnScreen";
            this.countElementsOnScreen.Size = new System.Drawing.Size(0, 13);
            this.countElementsOnScreen.TabIndex = 0;
            // 
            // selButton
            // 
            this.selButton.AutoSize = true;
            this.selButton.Location = new System.Drawing.Point(13, 232);
            this.selButton.Name = "selButton";
            this.selButton.Size = new System.Drawing.Size(56, 17);
            this.selButton.TabIndex = 1;
            this.selButton.TabStop = true;
            this.selButton.Text = "Button";
            this.selButton.UseVisualStyleBackColor = true;
            // 
            // selTextbox
            // 
            this.selTextbox.AutoSize = true;
            this.selTextbox.Location = new System.Drawing.Point(75, 232);
            this.selTextbox.Name = "selTextbox";
            this.selTextbox.Size = new System.Drawing.Size(63, 17);
            this.selTextbox.TabIndex = 2;
            this.selTextbox.TabStop = true;
            this.selTextbox.Text = "Textbox";
            this.selTextbox.UseVisualStyleBackColor = true;
            // 
            // selLabel
            // 
            this.selLabel.AutoSize = true;
            this.selLabel.Location = new System.Drawing.Point(144, 232);
            this.selLabel.Name = "selLabel";
            this.selLabel.Size = new System.Drawing.Size(51, 17);
            this.selLabel.TabIndex = 3;
            this.selLabel.TabStop = true;
            this.selLabel.Text = "Label";
            this.selLabel.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.selLabel);
            this.Controls.Add(this.selTextbox);
            this.Controls.Add(this.selButton);
            this.Controls.Add(this.countElementsOnScreen);
            this.Name = "GUI";
            this.Text = "Dynamic Controls";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GUI_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countElementsOnScreen;
        private System.Windows.Forms.RadioButton selButton;
        private System.Windows.Forms.RadioButton selTextbox;
        private System.Windows.Forms.RadioButton selLabel;
    }
}

