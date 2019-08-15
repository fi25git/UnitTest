using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BadewanneMVC
{
    class BadewannenZeigerView: Control, IBadewanneView 
    {
        public event EventHandler ViewChanged;

        public int MaxVal { get; set; }
        public int Val { get; set; }

        public void ControllerInput(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public void ModelChanged(object sender, EventArgs e)
        {
            //Zeiger zeichnen
            Val = ((IBadewanneModel)sender).Fuellstand;
            
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            float winkel = (float)Val / (float)MaxVal * 360.0f;
            e.Graphics.DrawArc(Pens.Aqua, new Rectangle(new Point(0,0), this.Size), -90.0f, winkel);
        }
    }
}
