using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaprekarZahlen
{
    public class Kaprekar
    {   
        public static int Paprika(int n)
        {
            int zahl = 0;
            int zaehler = 1;
            if (n == 1) { return n; }
            for (int i = 1; i < n; i++)
            {
                
                int quadrat = zaehler * zaehler;
                if ((quadrat.ToString().Length % 2) == 0)
                {
                    int teiler = (quadrat.ToString().Length / 2);
                    int zwerg = (Convert.ToInt32(quadrat.ToString().Substring(0, teiler))) + (Convert.ToInt32(quadrat.ToString().Substring(teiler, teiler)));

                    if (zwerg == zaehler)
                    {
                        zahl++;
                        if (n == zahl)
                        {
                            return zaehler;
                        }
                        zaehler++;
                    }
                }
                else
                {
                    zaehler++;
                    break;
                }
            }
            return n; 
            
        }
        
    }
}
