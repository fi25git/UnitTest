using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaprekarZahlen
{
    public class ASperling
    {
        private static List<int> kaprikarArray = new List<int>();

        public static int getNumber(int n)
        {
            makeKaprikarArray();
            return kaprikarArray[n-1];
        }

        public static void makeKaprikarArray()
        {
            for (int i = 0; i < 1000000; i++)
            {
                if (ASperling.isKaprekar(i))
                {
                    kaprikarArray.Add(i);
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("-------------------------------------");
        }

        public static bool isKaprekar(long n)
        {
            if (n == 1)
            {
                return true;
            }
                
            long sq_n = n * n;
            int count_digits = 0;
            while (sq_n != 0)
            {
                count_digits++;
                sq_n /= 10;
            }

            sq_n = n * n;
            for (int i = 1; i < count_digits; i++)
            {
                int eq_parts = (int)Math.Pow(10, i);
                if (eq_parts == n)
                    continue;
                long sum = sq_n / eq_parts + sq_n % eq_parts; // 81 / 10 + 81 % 10; // 2025 / 100 + 
                if (sum == n)
                {
                    //Console.WriteLine("Kaprekar");
                    return true;
                }

            }
            //Console.WriteLine("nicht Kaprekar");
            return false;
        }

        //public static int getKaprekar(int n)
        //{
        //    int summe = 0;
        //    string q = Convert.ToString(n * n);
        //    int laenge = q.Length / 2;
        //    if (n != 1)
        //    { 
        //        string e1 = q.Substring(0, laenge);
        //        if ((Convert.ToInt32(q) % 2) != 0)
        //        {
        //            if (e1[e1.Length - 1] == '0')
        //            {
        //                e1 = e1.Substring(0, e1.Length - 1);
        //            }

        //        }

        //        if ((Convert.ToInt32(e1) % 100) == 0)
        //        {
        //            e1 = e1.Substring(0, e1.Length - 2);
        //        }

        //        string e2 = q.Substring(laenge);
        //        Console.WriteLine("q = " + q + "; e1: " + e1 + "; e2: " + e2);
        //        summe = Convert.ToInt32(e1) + Convert.ToInt32(e2);

        //    }
        //    else
        //    {
        //        summe = 1;
        //    }
        //    Console.WriteLine("Ergebnis: " + summe);

        //    return summe;
        //}


    }
}
