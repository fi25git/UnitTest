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

        public void ModelChanged(object sender, EventArgs e)
        {
             speaker.Rate = 1;
            speaker.Volume = 100;
            speaker.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
           

                speaker.SpeakAsync("Der Füllstand beträgt: " + ((IBadewanneModel)sender).Fuellstand + " Liter");
          if( ((IBadewanneModel)sender).Voll)
            {
                speaker.SpeakAsync("Achtung die Badewanne läuft über!");

            }
        }



    }
}
