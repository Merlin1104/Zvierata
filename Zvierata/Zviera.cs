using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zvierata
{
    class Zviera
    {
        protected string typ,meno,druh;
        protected int vek;
        protected bool domace, cicavec;
        protected float radost;

        public Zviera(string typ, string meno,string druh, int vek, bool domace, bool cicavec, float radost)
        {
            this.typ = typ;
            this.meno = meno;
            this.druh = druh;
            this.vek = vek;
            this.domace = domace;
            this.cicavec = cicavec;
            this.radost = radost;
        }

        public void info()
        {
            Console.WriteLine("Toto zviera je: {0} \nMeno: {1} \nDruh: {2} \nVek: {3} r. \nDomace: {4} \nCicavec: {5} \nRadost: {6}",typ, meno,druh, vek, domace, cicavec,radost);
        }

        public void VydajZvuk()
        {
            Console.WriteLine("toto je obecny zvuk zvirete: XXX");
        }


    }
}
