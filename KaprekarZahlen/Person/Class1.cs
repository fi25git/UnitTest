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
        bool verheiratet;
        bool geschieden;
        bool verwitwet;

        int hochzeit = 0;
        int scheidung = 0;
        int witwer = 0;
        
        public void heiraten()
        {
            if (Ledig)
            {
                verheiratet = true;
                ledig = false;
                hochzeit++;
            }
            if (Geschieden)
            {
                verheiratet = true;                
                geschieden = false;
                hochzeit++;
            }
            if (Verwitwet)
            {
                verheiratet = true;               
                verwitwet = false;
                hochzeit++;
            }
        }
        public void annulieren()
        {
            if (Verheiratet && hochzeit==1)
            {
                ledig = true;
                verheiratet = false;
            }
            if (Verheiratet && witwer >= 1)
            {
                verheiratet = false;                
                verwitwet = true;
            }
            if (Verheiratet && scheidung >= 1)
            {
                verheiratet = false;                
                geschieden = true;
            }
        }
        public void scheiden()
        {
            if (Verheiratet)
            {
                geschieden = true;                
                verheiratet = false;
                scheidung++;
            }
        }
        public void PartnerTod()
        {
            if (Verheiratet)
            {
                verwitwet = true;                
                verheiratet = false;
                witwer++;
            }
        }
    }
}
