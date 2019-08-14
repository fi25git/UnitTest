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
            IBadewanneView v = new KlannView1();

            m.ModelChanged += v.ModelChanged;
            m.fuellen(50);
            m.fuellen(20);
        }

    
    }
}
