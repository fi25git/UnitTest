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
            BadewanneTonView tv = new BadewanneTonView();
            IBadewanneController c = thieleController1;
            c.Input += m.ControllerInput;
            IBadewanneController co = zallmanzigController1;
            co.Input += m.ControllerInput;

            // Nachrichten über MessageBox
            Iview i = new Iview();
            m.ModelChanged += i.Zustandwechsel;

            m.ModelChanged += v.ModelChanged;
            m.ModelChanged += tv.ModelChanged;
            //m.fuellen(50);
            //m.fuellen(20);

            
            //progressBar.Increment(50);
            this.Controls.Add(progressBar);
            progressBar.Location = new System.Drawing.Point(350, 350);
            progressBar.Maximum = m.Kapazitaet;
        }

        private void M_ModelChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            double zwerg = (this.ClientSize.Height - progressBar.Height) / 1.3;
            progressBar.Top = Convert.ToInt32(zwerg);
            progressBar.Left = (this.ClientSize.Width - progressBar.Width) / 2;


        }
    }
}
