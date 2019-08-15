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
        // Text-to-Speech Objekt erstellen
        SpeechSynthesizer speaker = new SpeechSynthesizer();

        public event EventHandler ViewChanged;

        public void ControllerInput(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ModelChanged(object sender, EventArgs e)
        {
                if(speaker.State == SynthesizerState.Speaking)
            {
                speaker.SpeakAsyncCancelAll();
            }
                // Sprachgeschwindigkeit
                speaker.Rate = 1;
                // Lautstärke
                speaker.Volume = 100;
                // Spracheinstellung
                speaker.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                int restmenge = ((IBadewanneModel)sender).Kapazitaet - ((IBadewanneModel)sender).Fuellstand;
                speaker.SpeakAsync("Der Füllstand beträgt: " + ((IBadewanneModel)sender).Fuellstand + " Liter");
                if (!((IBadewanneModel)sender).Voll)
                {
                    speaker.SpeakAsync("Es können noch: " + restmenge + " Liter eingelassen werden");
                }
                if (((IBadewanneModel)sender).Voll)
                {
                    speaker.SpeakAsync("Achtung die Badewanne läuft über!");
                }
            
        }
    }
}
