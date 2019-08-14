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
        public bool Geschieden { get { return geschieden; } }
        public bool Verwitwet { get { return verwitwet; } }

        bool ledig = true;
        bool verheiratet;
        bool geschieden;
        bool verwitwet;
        bool witwer;
        bool ehemann;


        public void heiraten()
        {
            if (ledig == true)
            {
                verheiratet = true;
                ledig = false;
            }
            else if (geschieden == true)
            {
                verheiratet = true;
                geschieden = false;
            }
            else if (verwitwet == true)
            {
                verheiratet = true;
                verwitwet = false;
                witwer = true;
            }
        }
        public void annulieren()
        {
            if (verheiratet == true && witwer == false && ehemann == false)
            {
                verheiratet = false;
                ledig = true;
            }
            else if (verheiratet == true && witwer == true)
            {
                verwitwet = true;
                verheiratet = false;
            }
            else if (verheiratet == true && ehemann == true)
            {
                geschieden = true;
                verheiratet = false;
            }
        }
        public void scheiden()
        {
            geschieden = true;
            verheiratet = false;
            ehemann = true;
            witwer = false;
        }
        public void PartnerTod()
        {
            verwitwet = true;
            verheiratet = false;
            witwer = true;
        } 
    }
}
