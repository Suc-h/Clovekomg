using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapaauto
{
   class Clovek
    {
        string jmeno;
        DateTime narozeni;
        
        public Clovek(string jmeno, string narozeni)
        {
            this.jmeno = jmeno; 
            this.narozeni = DateTime.Parse(narozeni);
        }
        public Clovek(string jmeno, DateTime narozeni)
        {
            this.jmeno = jmeno;
            this.narozeni = narozeni;
        }

        public void NastavJmeno(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public string VypisJmeno()
        {
            return jmeno;
        }

        public int Vek(int b)
        {
           
            TimeSpan a = DateTime.Now -narozeni;
            if (b == 1)
            {
                return a.Days;
            }
            else
            {
                return Convert.ToInt32(a.Days / 365.25);
            }
        }
        public bool plnolety()
        {
            if (Vek(0) >= 18)
            {

                return true;

            }
            else
            {

                return false;
            }
        }
        public string Starsi(Clovek dva)
        {
            if (dva.Vek(1) > this.Vek(1))
                return "Starší: " + dva.VypisJmeno();
            return "Starší: " + this.VypisJmeno();
        }
        public override string ToString()
        {
            if (plnolety() == true)
            {
                return this.VypisJmeno()+ " je mu: " +this.Vek(0) + " a je plnoletý.";
            }
            else
            {
                return this.VypisJmeno() + " je mu: " + this.Vek(0) + " a není plnoletý.";
            }
           
        }
    }
}
    