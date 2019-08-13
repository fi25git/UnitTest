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
            if (n < 1) throw new ArithmeticException("es gibt keine 0te Kaprikazahl");
            int count = 0;
            int a = 1;
            while (true)
            {
                if (IsKaprekar(a))
                {
                    count++;
                    if (count == n) return a;
                }
                a++;
            }
        }

        private static bool IsKaprekar(int a)
        {
            long zw = (long)a * (long)a;
            if (zw < 0) throw new ArithmeticException();
            string ziffern = zw.ToString();
            int teil = ziffern.Length / 2;
            int rest = ziffern.Length % 2;
            string vorn = ziffern.Substring(0, teil);
            string hinten = ziffern.Substring(teil, teil + rest);
            int b = vorn.Length == 0 ? 0 : Convert.ToInt32(vorn);
            int c = Convert.ToInt32(hinten);

            do {
                if ((b + c) == a) return true;
                if (b!=0 && b % 10 == 0) b = b / 10;
                else break;
            }
            while (true);
            return false;
        }
    }
}
