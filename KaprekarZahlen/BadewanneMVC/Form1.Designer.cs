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
            this.btnAb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAuf
            // 
            this.btnAuf.Location = new System.Drawing.Point(0, 0);
            this.btnAuf.Name = "btnAuf";
            this.btnAuf.Size = new System.Drawing.Size(87, 23);
            this.btnAuf.TabIndex = 0;
            this.btnAuf.Text = "Hahn auf";
            this.btnAuf.UseVisualStyleBackColor = true;
            this.btnAuf.Click += new System.EventHandler(this.btnAuf_Click);
            // 
            // btnAb
            // 
            this.btnAb.Location = new System.Drawing.Point(0, 29);
            this.btnAb.Name = "btnAb";
            this.btnAb.Size = new System.Drawing.Size(87, 23);
            this.btnAb.TabIndex = 1;
            this.btnAb.Text = "Stöpsel Ziehen";
            this.btnAb.UseVisualStyleBackColor = true;
            this.btnAb.Click += new System.EventHandler(this.btnAb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAb);
            this.Controls.Add(this.btnAuf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuf;
        private System.Windows.Forms.Button btnAb;
    }
}

