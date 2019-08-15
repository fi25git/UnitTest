using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BadewanneMVC
{
    class BadewannenZeigerView : Control, IBadewanneView
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
            float prozent = (float)Val / (float)MaxVal;

            float winkel = prozent * 360.0f;
            Pen p = new Pen(Brushes.Green, 10.0f);
            if (prozent > .6f) p = new Pen(Brushes.Yellow, 15.0f);
            if (prozent > .85f) p = new Pen(Brushes.Orange, 20.0f);
            if (prozent > .99f) p = new Pen(Brushes.Red, 30.0f);

            e.Graphics.DrawArc(p, new Rectangle(new Point(0, 0), this.Size), -90.0f, winkel);
        }
    }
}
