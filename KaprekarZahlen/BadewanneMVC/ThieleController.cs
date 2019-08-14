using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadewanneMVC
{
    class ThieleController:Control, IBadewanneController
    {
        public event EventHandler Input;

       

        public void ModelChanged(object sender, EventArgs e)
        {
            
        }

        public void ViewChanged(object sender, EventArgs e)
        {
            
        }

        public ThieleController()
        {
            Button fuell = new Button();
            this.Controls.Add(fuell);
            fuell.Click += Fuell_Click;

        }

        private void Fuell_Click(object sender, EventArgs e)
        {
            Console.WriteLine("tets");

            //Console.WriteLine(Input.GetInvocationList().Length);

            if (Input != null)
            {

                ((IBadewanneModel)Input.GetInvocationList()[0].Target).fuellen(10);
            }
        }
    }

    class ControllerEventArgs : EventArgs
    {
        public ControllerEventArgs(string msg)
        {
            this.msg = msg;
        }
        string msg;
        public string Message { get { return msg; }}
    }

}
