using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace BadewanneMVC
{

    class BadewanneTonView : IBadewanneView
    {
        SpeechSynthesizer speaker = new SpeechSynthesizer();

        public event EventHandler ViewChanged;

        public void ControllerInput(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ModelChanged(object sender, EventArgs e)
        {
            speaker.Rate = 1;
            speaker.Volume = 100;
            speaker.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            int restmenge = ((IBadewanneModel)sender).Kapazitaet - ((IBadewanneModel)sender).Fuellstand;
            if (!((IBadewanneModel)sender).Voll)
                speaker.SpeakAsync("Der Füllstand beträgt: " + ((IBadewanneModel)sender).Fuellstand + " Liter");
            speaker.SpeakAsync("Es können noch: " + restmenge + " Liter eingelassen werden");
            if (((IBadewanneModel)sender).Voll)
            {
                speaker.SpeakAsync("Achtung die Badewanne läuft über!");

            }
        }



    }
}
