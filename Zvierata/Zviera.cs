using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zvierata
{
    class Zviera
    {
        protected string meno,druh;
        protected int vek;
        protected bool domace, cicavec;
        protected float radost;

        public Zviera(string meno,string druh, int vek, bool domace, bool cicavec, float radost)
        {
            this.meno = meno;
            this.druh = druh;
            this.vek = vek;
            this.domace = domace;
            this.cicavec = cicavec;
            this.radost = radost;
        }

        public void info()
        {
            Console.WriteLine("Toto zviera sa vola: {0} {1} {2} {3}", meno, vek, domace, cicavec);
        }


    }
}
