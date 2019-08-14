using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadewanneMVC
{
    class ASpBadewanneModel : IBadewanneModel
    {
        public bool Voll { get { return voll; } }
        public int Fuellstand { get { return fuellstand; } }
        public int Kapazitaet { get { return kapazitaet; } }

        public event EventHandler ModelChanged;

        bool voll;
        int fuellstand;
        int kapazitaet;

        public ASpBadewanneModel()
        {
            kapazitaet = 300;
            fuellstand = 0;
        }

        public void ablassen(int liter)
        {
            fuellstand -= liter;
            voll = false;
            if (fuellstand < 0)
            {
                fuellstand = 0;
            }
            if (ModelChanged != null)
            {
                ModelChanged(this, null);
            }
        }

        public void fuellen(int liter)
        {
            fuellstand += liter;
            if (fuellstand >= kapazitaet)
            {
                fuellstand = kapazitaet;
                voll = true;
            }
            if (ModelChanged != null)
            {
                ModelChanged(this, null);
            }
        }
    }
}
