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

        // Timer 
        Timer timer = new Timer();
        
        
        public void ModelChanged(object sender, EventArgs e)
        {

        }

        public void ViewChanged(object sender, EventArgs e)
        {

        }

        public ZallmanzigController()
        {
            timer.Tick += Timer_Tick;

            // Radio Button Offen
            RadioButton offen = new RadioButton();
            offen.Location = new Point(0, 10);
            offen.Text = "Offen";
            this.Controls.Add(offen);
            offen.CheckedChanged += Offen_CheckedChanged;

            // Radio Button Geschlossen
            RadioButton geschlossen = new RadioButton();
            geschlossen.Location = new Point(0, 50);
            geschlossen.Text = "geschlossen";
            geschlossen.Checked = true;
            this.Controls.Add(geschlossen);
            geschlossen.CheckedChanged += Geschlossen_CheckedChanged;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ((IBadewanneModel)Input.GetInvocationList()[0].Target).fuellen(1);
        }

        private void Geschlossen_CheckedChanged(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Offen_CheckedChanged(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
