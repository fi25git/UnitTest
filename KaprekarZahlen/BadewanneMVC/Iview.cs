using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BadewanneMVC
{
    class Iview : IBadewanneView

    {
       

        public event EventHandler ViewChanged;
        int zustand { get; set; }

        public int Zustandwechsel()
        {

           
            if (IBadewanneModel.M >= 30)
            {
                return 1;
            }
            return 0;

        }  
        
       
    }
}
