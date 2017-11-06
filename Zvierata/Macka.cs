using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zvierata
{
    class Macka : Zviera
    {
        private float dlzkaUsi;

        public Macka(string typ, string meno, string druh, int vek, bool domace, bool cicavec, float radost,float dlzkaUsi) : base(typ,meno,druh, vek, domace, cicavec, radost)
        {
            this.dlzkaUsi = dlzkaUsi;
        }

        

        public new void info()
        {
            Console.WriteLine("Toto zviera je: {0} \nMeno: {1}\nDruh: {2} \nVek: {3} r. \nDomace: {4} \nCicavec: {5} \nRadost: {6} \nDlzka usi: {7} cm.",
                typ ,meno, druh, vek, domace, cicavec, radost, dlzkaUsi);
        }

        public new void VydajZvuk()
        {
            Console.WriteLine("toto je obecny zvuk zvirete: MEOW !");
        }

        public void Mnaukaj()
        {
            Console.WriteLine("Meow !");
            radost -= 0.1f;
            Console.WriteLine("Nova radost je: {0}", radost);
        }
    }
}
