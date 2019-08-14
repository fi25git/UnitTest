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
        public ProgressBar progressBar;
        public Form1()
        {
            InitializeComponent();
            IBadewanneModel m = new ASpBadewanneModel();
            progressBar = new ProgressBar();
            KlannView1 v = new KlannView1(this,progressBar);

            m.ModelChanged += v.ModelChanged;
            m.fuellen(50);
            m.fuellen(20);

            
            //progressBar.Increment(50);
            this.Controls.Add(progressBar);
        }

        private void M_ModelChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
