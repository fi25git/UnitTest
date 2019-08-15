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

            //PictureBox pictureBox1 = new PictureBox();
            //pictureBox1.Image = res.badewanne;
            //form1.progressBar.Increment(((IBadewanneModel)sender).Fuellstand);
            //form1.progressBar.Value = (((IBadewanneModel)sender).Fuellstand);
            Image neu = (Image)res.ResourceManager.GetObject("badewanne1");
            if ((((IBadewanneModel)sender).Fuellstand) < 10)
            {
                form1.BackgroundImage = neu;
            }
            //if ((((IBadewanneModel)sender).Fuellstand) < 20 && (((IBadewanneModel)sender).Fuellstand) >= 10)
            //{
            //    neu = (Image)res.ResourceManager.GetObject("badewanne10");
            //    form1.BackgroundImage = neu;
            //}
            //if ((((IBadewanneModel)sender).Fuellstand) < 30 && (((IBadewanneModel)sender).Fuellstand) >= 20)
            //{
            //    neu = (Image)res.ResourceManager.GetObject("badewanne20");
            //    form1.BackgroundImage = neu;
            //}
            //if ((((IBadewanneModel)sender).Fuellstand) < 40 && (((IBadewanneModel)sender).Fuellstand) >= 30)
            //{
            //    neu = (Image)res.ResourceManager.GetObject("badewanne30");
            //    form1.BackgroundImage = neu;
            //}
            //if ((((IBadewanneModel)sender).Fuellstand) < 50 && (((IBadewanneModel)sender).Fuellstand) >= 40)
            //{
            //    neu = (Image)res.ResourceManager.GetObject("badewanne40");
            //    form1.BackgroundImage = neu;
            //}
            //if ((((IBadewanneModel)sender).Fuellstand) < 60 && (((IBadewanneModel)sender).Fuellstand) >= 50)
            //{
            //    neu = (Image)res.ResourceManager.GetObject("badewanne50");
            //    form1.BackgroundImage = neu;
            //}
            //if ((((IBadewanneModel)sender).Fuellstand) < 70 && (((IBadewanneModel)sender).Fuellstand) >= 60)
            //{
            //    neu = (Image)res.ResourceManager.GetObject("badewanne60");
            //    form1.BackgroundImage = neu;
            //}
            //if ((((IBadewanneModel)sender).Fuellstand) < 80 && (((IBadewanneModel)sender).Fuellstand) >= 70)
            //{
            //    neu = (Image)res.ResourceManager.GetObject("badewanne70");
            //    form1.BackgroundImage = neu;
            //}

            neu = (Image)res.ResourceManager.GetObject("badewanne" + (((IBadewanneModel)sender).Fuellstand/10)+"0");
            form1.BackgroundImage = neu;
        }
    }
}
