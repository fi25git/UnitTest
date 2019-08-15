using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadewanneMVC
{
    class ThieleController:Control, IBadewanneController
    {
        public event EventHandler Input;
       
        public void ModelChanged(object sender, EventArgs e)
        {
            
        }

        public void ViewChanged(object sender, EventArgs e)
        {
            
        }

        public ThieleController()
        {
            Button fuell = new Button();
            fuell.Location = new Point(0, 10);
            fuell.Text = "Füllen";            
            this.Controls.Add(fuell);
            fuell.Click += Fuell_Click;
            Button ablassen = new Button();
            ablassen.Location = new Point(0, 50);
            ablassen.Text = "Ablassen";
            this.Controls.Add(ablassen);
            ablassen.Click += Ablassen_Click;           
        }

        private void Ablassen_Click(object sender, EventArgs e)
        {
            if (Input != null)
            {
                ((IBadewanneModel)Input.GetInvocationList()[0].Target).ablassen(10);
            }
        }

        private void Fuell_Click(object sender, EventArgs e)
        {
            if (Input != null)
            {
                ((IBadewanneModel)Input.GetInvocationList()[0].Target).fuellen(10);
            }
        }        
    }
}
