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
        }

        private void btnAuf_Click(object sender, EventArgs e)
        {
            füllen(10);
        }

        private void btnAb_Click(object sender, EventArgs e)
        {
            ablassen(10);
        }
    }
}
