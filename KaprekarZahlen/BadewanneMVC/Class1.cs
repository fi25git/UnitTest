using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadewanneMVC
{
    class KlannView : Control, IBadewanneView 
    {
        public event EventHandler ViewChanged;

        public void ModelChanged(Object sender, EventArgs e)
        {
            Console.WriteLine(((IBadewanneModel)sender).Fuellstand);
        }
    }
}
