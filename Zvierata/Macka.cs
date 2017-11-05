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

        public Macka(string meno,string druh, int vek, bool domace, bool cicavec, float radost,float dlzkaUsi) : base(meno,druh, vek, domace, cicavec, radost)
        {
            this.dlzkaUsi = dlzkaUsi;
        }

        public void Mnaukaj ()
        {
            Console.WriteLine("Meow !");
            radost -= 0.1f;
            Console.WriteLine("Nova radost je: {0}", radost);
        }

        public new void info()
        {
            Console.WriteLine("Toto zviera sa vola: {0} \nDruh: {1}\nVek: {2} \nDomace?: {3} \nCicavec?: {4} \nRadost: {5} \nDlzka usi: {6}",
                meno, druh, vek, domace, cicavec, radost, dlzkaUsi);
        }
    }
}
