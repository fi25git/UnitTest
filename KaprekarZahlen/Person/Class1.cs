using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public bool Ledig       { get { return ledig; } }
        public bool Verheiratet { get { return verheiratet; } }
        public bool Geschieden  { get { return geschieden; } }
        public bool Verwitwet   { get { return verwitwet; } }

        bool ledig = true;
        bool verheiratet = true;
        bool geschieden = true;
        bool verwitwet = true;

        public void heiraten()
        {
            if (Ledig || Geschieden || Verwitwet)
            {
                verheiratet = true;
                ledig = false;
                geschieden = false;
                verwitwet = false;
            }
        }
        public void annulieren()
        {
            if (Verheiratet)
            {
                ledig = true;
                verheiratet = false;
            }
            if (Verwitwet)
            {
                verheiratet = true;
                ledig = false;
                verwitwet = false;
            }
            if (Geschieden)
            {
                verheiratet = true;
                ledig = false;
                geschieden = false;
            }
        }
        public void scheiden()
        {
            if (Verheiratet)
            {
                geschieden = true;
                ledig = false;
                verheiratet = false;
            }
        }
        public void PartnerTod()
        {
            if (Verheiratet)
            {
                verwitwet = true;
                ledig = false;
                verheiratet = false;
            }
        }
    }
}
