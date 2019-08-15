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

        ComboBox cbLiter;

        public ThieleController()
        {
            Button fuell = new Button();
            fuell.Location = new Point(0, 10);
            fuell.Text = "Füllen";            
            this.Controls.Add(fuell);
            
            cbLiter = new ComboBox();
            cbLiter.Items.AddRange(new object[]
            {"10", "20", "30", "40", "50", "60", "70", "80",
             "90", "100", "110", "120", "130", "140", "150",
             "160", "170", "180", "190", "200", "210", "220",
             "230", "240", "250", "260", "270", "280", "290", "300"
            });
            cbLiter.Location = new System.Drawing.Point(80, 10);
            cbLiter.Text = "Liter";
            cbLiter.Size = new System.Drawing.Size(50, 20);
            this.Controls.Add(cbLiter);
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
                ((IBadewanneModel)Input.GetInvocationList()[0].Target).ablassen(Convert.ToInt32(cbLiter.SelectedItem));
            }
        }

        private void Fuell_Click(object sender, EventArgs e)
        {            
            if (Input != null)
            {
                ((IBadewanneModel)Input.GetInvocationList()[0].Target).fuellen(Convert.ToInt32(cbLiter.SelectedItem));
            }
        }        
    }
}
