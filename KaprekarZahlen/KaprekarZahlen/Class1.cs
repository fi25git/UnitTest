using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaprekarZahlen
{
    public class Kaprekar
    {
        public static bool getNumber(int n)
        {
            if (n == 1)
                return true;
            int sq_n = n * n;
            int count_digits = 0;
            while (sq_n != 0)
            {
                count_digits++;
                sq_n /= 10;
            }
            sq_n = n * n;
            for (int r_digits = 1; r_digits < count_digits; r_digits++)
            {
                int eq_parts = (int)Math.Pow(10, r_digits);
                if (eq_parts == n)
                    continue;
                int sum = sq_n / eq_parts + sq_n % eq_parts;
                if (sum == n)
                {
                    Console.WriteLine("Kaprekar");
                    return true;
                }

            }
            Console.WriteLine("nicht Kaprekar");
            return false;
        }
    }
}
