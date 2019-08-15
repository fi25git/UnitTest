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
           
            // Sprachgeschwindigkeit
            speaker.Rate = 1;
            // Lautstärke
            speaker.Volume = 100;
            // Spracheinstellung
            speaker.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            int restmenge = ((IBadewanneModel)sender).Kapazitaet - ((IBadewanneModel)sender).Fuellstand;
            if (restmenge == Convert.ToInt32(((IBadewanneModel)sender).Kapazitaet))
            {
                speaker.SpeakAsync("Die Badewanne ist leer");
                speaker.SpeakAsync("Es können noch: " + restmenge + " Liter eingelassen werden");
            }
            if (restmenge == Convert.ToInt32(((IBadewanneModel)sender).Kapazitaet)*0.25)
            {
                speaker.SpeakAsync("Der Füllstand beträgt: " + ((IBadewanneModel)sender).Fuellstand + " Liter");
                speaker.SpeakAsync("Es können noch: " + restmenge + " Liter eingelassen werden");
            }
            if (restmenge > Convert.ToInt32(((IBadewanneModel)sender).Kapazitaet)/2)
            {
               
                speaker.SpeakAsync("Die Badewann ist zur hälfte gefüllt");
                speaker.SpeakAsync("Es können noch: " + restmenge + " Liter eingelassen werden");
         
            }
            if (restmenge == Convert.ToInt32(((IBadewanneModel)sender).Kapazitaet) * 0.75)
            {
                speaker.SpeakAsync("Der Füllstand beträgt: " + ((IBadewanneModel)sender).Fuellstand + " Liter");
                speaker.SpeakAsync("Es können noch: " + restmenge + " Liter eingelassen werden");
            }


            if (((IBadewanneModel)sender).Voll)
            {
                speaker.SpeakAsync("Achtung die Badewanne läuft über!"); //"So, jetzt aber ab nach Hause Ihr kleinen Racker!"
            }

        }
    }
}
