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
        void ControllerInput(Object sender, EventArgs e);
        void ViewChanged(Object sender, EventArgs e);
    }

    interface IBadewanneView
    {
        event EventHandler ViewChanged;
        void ModelChanged(Object sender, EventArgs e);
        void ControllerInput(Object sender, EventArgs e);
    }

    interface IBadewanneController
    {
        event EventHandler Input;
        void ModelChanged(Object sender, EventArgs e);
        void ViewChanged(Object sender, EventArgs e);
    }
}
