using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zvierata
{
    class Program
    {
        static void Main(string[] args)
        {
            Pes pes = new Pes("Dunco","Vlciak", 3, true, true, 0.4f,10);
            pes.info();
            pes.stekaj();
            pes.stekaj();

            Console.WriteLine();

            Macka macka = new Macka("Elza", "Britska zlta", 8, true, true, 0.6f, 8.5f);
            macka.info();
            macka.Mnaukaj();

            Console.ReadKey();
        }
    }

    
}
