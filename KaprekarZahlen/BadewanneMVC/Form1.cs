﻿using System;
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
            KlannView1 v = new KlannView1();
            ThieleController c = new ThieleController();

            m.ModelChanged += v.ModelChanged;
            c.ControllerInput += m.ControllerInput;
            m.fuellen(50);
            m.fuellen(20);
        }

    
    }
}
