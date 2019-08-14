using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadewanneMVC
{
    class KlannView1: IBadewanneView
    {
        public event EventHandler ViewChanged;

        public void ModelChanged(object sender, EventArgs e)
        {
            Console.WriteLine(((IBadewanneModel)sender).Fuellstand);

        }
    }
}
