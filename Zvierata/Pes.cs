using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zvierata
{
    class Pes : Zviera
    {
        private int dlzkaNosa; 


        public Pes(string meno,string druh, int vek, bool domace, bool cicavec,float radost, int dlzkaNosa) : base(meno,druh, vek, domace, cicavec, radost)
        {
            this.dlzkaNosa = dlzkaNosa;
        }

        public new void info()
        {
            Console.WriteLine("Toto zviera sa vola: {0} \nDruh: {1}\nVek: {2} \nDomace?: {3} \nCicavec?: {4} \nRadost: {5} \nDlzka nosa: {6}",
                meno, druh, vek, domace, cicavec, radost, dlzkaNosa);
        }

        public void stekaj()
        {
            Console.WriteLine("Haf !");
            radost += 0.1f;
            Console.WriteLine("Nova uroven radosti: {0}",radost);
        }
    }
}
