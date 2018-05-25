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
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.countElementsOnScreen);
            this.Name = "GUI";
            this.Text = "Dynamic Controls";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GUI_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countElementsOnScreen;
    }
}

