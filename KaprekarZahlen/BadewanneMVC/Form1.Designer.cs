namespace BadewanneMVC
{
    partial class Form1
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
            this.btnAuf = new System.Windows.Forms.Button();
            this.btnZu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAuf
            // 
            this.btnAuf.Location = new System.Drawing.Point(0, 0);
            this.btnAuf.Name = "btnAuf";
            this.btnAuf.Size = new System.Drawing.Size(100, 23);
            this.btnAuf.TabIndex = 0;
            this.btnAuf.Text = "Hahn auf";
            this.btnAuf.UseVisualStyleBackColor = true;
            // 
            // btnZu
            // 
            this.btnZu.Location = new System.Drawing.Point(0, 29);
            this.btnZu.Name = "btnZu";
            this.btnZu.Size = new System.Drawing.Size(100, 23);
            this.btnZu.TabIndex = 1;
            this.btnZu.Text = "Wasser ablassen";
            this.btnZu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZu);
            this.Controls.Add(this.btnAuf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnAuf;
        private System.Windows.Forms.Button btnZu;
    }
}

