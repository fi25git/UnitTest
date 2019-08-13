using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public bool Ledig { get; set; }
        public bool Verheiratet { get; set; }
        public bool Geschieden{ get; set; }
        public bool Verwitwet { get; set; }

        public void heiraten()
        {
            Person neuling = new Person();
            neuling.Verheiratet = true; 
        }
        public void annulieren()
        {

        }
        public void scheiden()
        {

        }
        public void PartnerTod()
        {

        }
    }
}
