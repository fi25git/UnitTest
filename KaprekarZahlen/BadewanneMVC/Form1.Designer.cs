﻿using System.Windows.Forms;

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
            this.thieleController1 = new BadewanneMVC.ThieleController();
            this.zallmanzigController1 = new BadewanneMVC.ZallmanzigController();
            this.txtfstand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thieleController1
            // 
            this.thieleController1.Location = new System.Drawing.Point(42, 54);
            this.thieleController1.Name = "thieleController1";
            this.thieleController1.Size = new System.Drawing.Size(92, 90);
            this.thieleController1.TabIndex = 0;
            this.thieleController1.Text = "thieleController1";
            // 
            // zallmanzigController1
            // 
            this.zallmanzigController1.Location = new System.Drawing.Point(202, 54);
            this.zallmanzigController1.Name = "zallmanzigController1";
            this.zallmanzigController1.Size = new System.Drawing.Size(237, 90);
            this.zallmanzigController1.TabIndex = 1;
            this.zallmanzigController1.Text = "zallmanzigController1";
            // 
            // txtfstand
            // 
            this.txtfstand.AutoSize = true;
            this.txtfstand.Location = new System.Drawing.Point(354, 387);
            this.txtfstand.Name = "txtfstand";
            this.txtfstand.Size = new System.Drawing.Size(0, 13);
            this.txtfstand.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BadewanneMVC.res.badewanne2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtfstand);
            this.Controls.Add(this.zallmanzigController1);
            this.Controls.Add(this.thieleController1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private ThieleController thieleController1;
        private ZallmanzigController zallmanzigController1;
        private Label txtfstand;
    }
}

