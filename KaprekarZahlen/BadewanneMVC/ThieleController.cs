using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadewanneMVC
{
    class ThieleController : Control, IBadewanneController
    {
        public event EventHandler Input;

        

        ThieleController c = new ThieleController();
        
        IBadewanneController += IBadewanneModel;
    }
}
