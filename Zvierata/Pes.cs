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
        


        public Pes(string typ,string meno,string druh, int vek, bool domace, bool cicavec,float radost, int dlzkaNosa) : base(typ,meno,druh, vek, domace, cicavec, radost)
        {
            this.dlzkaNosa = dlzkaNosa;
        }

        public new void info()
        {
            Console.WriteLine("Toto zviera je: {0} \nMeno: {1}\nDruh: {2} \nVek: {3} r. \nDomace: {4} \nCicavec: {5} \nRadost: {6} \nDlzka nosa: {7} cm.",
                typ,meno, druh, vek, domace, cicavec, radost, dlzkaNosa);
        }

        

        public override void VydajZvuk()
        {
            Console.WriteLine("toto je obecny zvuk zvirete: HAF! ");
        }
        
        public void stekaj()
        {
            Console.WriteLine("Haf !");
            radost += 0.1f;
            Console.WriteLine("Nova uroven radosti: {0}", radost);
        }

        
        public override void NakrmZviera()
        {
            nakrmeny=true;
        }
        
    }
}
