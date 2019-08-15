using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadewanneMVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IBadewanneModel m = new ASpBadewanneModel();
            IBadewanneView v = new KlannView1(this, progressBar);
            IBadewanneView tv = new BadewanneTonView();
            IBadewanneController c = thieleController1;
            c.Input += m.ControllerInput;
            
            m.ModelChanged += v.ModelChanged;
            m.ModelChanged += tv.ModelChanged;
            m.fuellen(50);
            m.fuellen(20);
            m.fuellen(230);
            

        }

        private void btnAuf_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
