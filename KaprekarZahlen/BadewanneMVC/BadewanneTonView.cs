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
        int fuellstand;


        public void fuellen(int liter)
        {
            fuellstand += liter;
        }
        public void ablassen(int liter)
        {
            fuellstand += liter;
        }
        public void TexttoSpeech()
        {
            speaker.Rate = 1;
            speaker.Volume = 100;
            speaker.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            speaker.SpeakAsync("Der Füllstand beträgt: " + fuellstand);
        }
       
            
            

    }
}
