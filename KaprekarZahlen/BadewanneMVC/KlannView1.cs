using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BadewanneMVC
{
    class KlannView1: IBadewanneView
    {
        Form1 form1;
        ProgressBar progressBar;
        public KlannView1(Form1 form1, ProgressBar progressBar)
        {
            this.form1 = form1;
            this.progressBar = progressBar;
        }
        public event EventHandler ViewChanged;

        public void ControllerInput(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ModelChanged(object sender, EventArgs e)

        {
            Console.WriteLine(((IBadewanneModel)sender).Fuellstand);

            Image neu = (Image)res.ResourceManager.GetObject("badewanne1");
            if ((((IBadewanneModel)sender).Fuellstand) < 10)
            {
                form1.BackgroundImage = neu;
            }

            neu = (Image)res.ResourceManager.GetObject("badewanne" + (((IBadewanneModel)sender).Fuellstand/10)+"0");
            form1.BackgroundImage = neu;
        }
    }
}
