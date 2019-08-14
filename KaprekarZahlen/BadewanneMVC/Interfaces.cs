using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadewanneMVC
{
    interface IBadewanneModel
    {
        event EventHandler ModelChanged;
        bool Voll { get; }
        int Fuellstand { get; }
        int Kapazitaet { get; }
        void fuellen(int liter);
        void ablassen(int liter);
    }

    interface IBadewanneView
    {
        event EventHandler ViewChanged;        
    }

    interface IBadewanneController
    {
        event EventHandler Input;
    }
}
