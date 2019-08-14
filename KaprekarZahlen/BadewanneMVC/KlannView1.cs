using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadewanneMVC
{
    class KlannView1: IBadewanneView
    {
        Form1 form1;
        public KlannView1(Form1 form1)
        {
            this.form1 = form1;
        }
        public event EventHandler ViewChanged;

        public void ModelChanged(object sender, EventArgs e)

        {
            Console.WriteLine(((IBadewanneModel)sender).Fuellstand);
            
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = res.badewanne;
            form1.progressBar.Increment(50);
           
        }
    }
}
