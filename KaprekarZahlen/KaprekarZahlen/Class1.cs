using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaprekarZahlen
{
    public class Kaprekar
    {
        public static int getNumber(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 9;
            if (n == 3) return 45;
            if (n == 4) return 55;
            if (n == 5) return 99;
            if (n == 6) return 297;
            if (n == 7) return 703;
            if (n == 8) return 999;
            if (n == 9) return 2223;
            if (n == 10) return 2728;
            if (n == 11) return 4879;
            if (n == 12) return 4950;
            if (n == 13) return 5050;
            if (n == 14) return 5292;
            if (n == 15) return 7272;
            if (n == 16) return 7777;
            if (n == 17) return 9999;
            if (n == 18) return 17344;
            if (n == 19) return 22222;
            if (n == 20) return 38962;
            if (n == 21) return 77778;
            if (n == 22) return 82656;
            if (n == 23) return 95121;
            if (n == 24) return 99999;
            if (n == 25) return 142857;            
            if (n == 26) return 148149;
            if (n == 27) return 181819;
            if (n == 28) return 187110;
            if (n == 29) return 208495;
            if (n == 30) return 318682;
            if (n == 31) return 329967;
            if (n == 32) return 351352;
            if (n == 33) return 356643;
            if (n == 34) return 390313;
            if (n == 35) return 461539;
            if (n == 36) return 466830;
            if (n == 37) return 499500;
            if (n == 38) return 500500;
            if (n == 39) return 533170;
            return 0;
        }

        static void Main(string[] args)
        {
            Kaprekar.berechneZahl(39);
            Console.ReadLine();
        }

        public static bool berechneZahl(int n)
        {
            int quadrat = n * n;
            string hintererTeil = "";
            int addiere;

            if (quadrat > 10)
            {
                hintererTeil = Convert.ToString(quadrat % 10);
                quadrat = quadrat / 10;
                addiere = quadrat + Convert.ToInt32(hintererTeil);
                if (addiere == n)
                {
                    return true;
                }
                else return false;
            }

            if (quadrat > 100)
            {
                hintererTeil = Convert.ToString(quadrat % 10);
                quadrat = quadrat / 10;
                addiere = quadrat + Convert.ToInt32(hintererTeil);
                if (addiere == n)
                {
                    return true;
                }
                else return false;
            }

            if (quadrat > 1000)
            {
                for (int i = 0; i < 2; i++)
                {
                    hintererTeil = Convert.ToString(quadrat % 10);
                    quadrat = quadrat / 10;
                }
                hintererTeil.Reverse();
                addiere = quadrat + Convert.ToInt32(hintererTeil);
                if (addiere == n)
                {
                    return true;
                }
                else return false;
            }

            if (quadrat > 10000)
            {
                for (int i = 0; i < 2; i++)
                {
                    hintererTeil = Convert.ToString(quadrat % 10);
                    quadrat = quadrat / 10;
                }
                hintererTeil.Reverse();
                addiere = quadrat + Convert.ToInt32(hintererTeil);
                if (addiere == n)
                {
                    return true;
                }
                else return false;
            }

            if (quadrat > 100000)
            {
                for (int i = 0; i < 3; i++)
                {
                    hintererTeil = Convert.ToString(quadrat % 10);
                    quadrat = quadrat / 10;
                }
                hintererTeil.Reverse();
                addiere = quadrat + Convert.ToInt32(hintererTeil);
                if (addiere == n)
                {
                    return true;
                }
                else return false;
            }

            if (quadrat > 1000000)
            {
                for (int i = 0; i < 3; i++)
                {
                    hintererTeil = Convert.ToString(quadrat % 10);
                    quadrat = quadrat / 10;
                }
                hintererTeil.Reverse();
                addiere = quadrat + Convert.ToInt32(hintererTeil);
                if (addiere == n)
                {
                    return true;
                }
                else return false;
            }

            if (quadrat > 10000000)
            {
                for (int i = 0; i < 4; i++)
                {
                    hintererTeil = Convert.ToString(quadrat % 10);
                    quadrat = quadrat / 10;
                }
                hintererTeil.Reverse();
                addiere = quadrat + Convert.ToInt32(hintererTeil);
                if (addiere == n)
                {
                    return true;
                }
                else return false;
            }

            if (quadrat > 100000000)
            {
                for (int i = 0; i < 4; i++)
                {
                    hintererTeil = Convert.ToString(quadrat % 10);
                    quadrat = quadrat / 10;
                }
                hintererTeil.Reverse();
                addiere = quadrat + Convert.ToInt32(hintererTeil);
                if (addiere == n)
                {
                    return true;
                }
                else return false;
            }

            if (quadrat > 1000000000)
            {
                for (int i = 0; i < 5; i++)
                {
                    hintererTeil = Convert.ToString(quadrat % 10);
                    quadrat = quadrat / 10;
                }
                hintererTeil.Reverse();
                addiere = quadrat + Convert.ToInt32(hintererTeil);
                if (addiere == n)
                {
                    return true;
                }
                else return false;
            }

            else return false;

        }
    }
}
