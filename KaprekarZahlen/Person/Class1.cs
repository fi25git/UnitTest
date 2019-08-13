using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public bool Ledig { get { return ledig; } }
        public bool Verheiratet { get { return verheiratet; } }
        public bool Geschieden{ get { return geschieden; } }
        public bool Verwitwet { get { return verwitwet; } }

        bool ledig;
        bool verheiratet;
        bool geschieden;
        bool verwitwet;

        public void heiraten()
        {
            if (ledig == true)
            {
                ledig = false;
                verheiratet = true;
            }

            if (geschieden==true)
            {
                geschieden = false;
                verheiratet = true;
            }

            if (verwitwet==true)
            {
                verwitwet = false;
                verheiratet = true;
            }
        }

        public void annulieren()
        {
            if (verheiratet==true)
            {
                verheiratet = false;
                ledig = true;
            }

            if (geschieden==true)
            {
                geschieden = false;
                verheiratet = true;
            }
        }

        public void scheiden()
        {
            if(verheiratet==true)
            {
                verheiratet = false;
                geschieden = true;
            }
        }

        public void PartnerTod()
        {
            if(verheiratet==true)
            {
                verheiratet = false;
                verwitwet = true;
            }
        }
    }
}
