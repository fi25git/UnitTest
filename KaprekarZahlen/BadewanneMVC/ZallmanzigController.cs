using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadewanneMVC
{
    class ZallmanzigController:Control, IBadewanneController
    {
        public event EventHandler Input;

        public void ModelChanged(object sender, EventArgs e)
        {

        }

        public void ViewChanged(object sender, EventArgs e)
        {

        }

        public ZallmanzigController()
        {
            RadioButton offen = new RadioButton();
            offen.Location = new Point(0, 10);
            offen.Text = "Offen";
            this.Controls.Add(offen);
            offen.CheckedChanged += Offen_CheckedChanged;

            RadioButton geschlossen = new RadioButton();
            geschlossen.Location = new Point(0, 50);
            geschlossen.Text = "geschlossen";
            this.Controls.Add(geschlossen);
            geschlossen.CheckedChanged += Geschlossen_CheckedChanged;
        }

        private void Geschlossen_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Offen_CheckedChanged(object sender, EventArgs e)
        {
            
        }


    }
}
