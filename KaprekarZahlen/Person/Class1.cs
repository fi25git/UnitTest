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
            if (ledig == true || geschieden == true || verwitwet == true)
            {
                verheiratet = true;
                ledig = false;
            }
        }
        public void annulieren()
        {
            if (verheiratet == true)
            {
                verheiratet = false;
                ledig = true;
            }
            else if (geschieden == true)
            {
                geschieden = false;
                verheiratet = true;
            }
        }
        public void scheiden()
        {
            geschieden = true;
            verheiratet = false;
        }
        public void PartnerTod()
        {
            verwitwet = true;
            verheiratet = false;
        }
    }
}
