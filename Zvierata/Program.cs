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
            Zviera zviera = new Zviera("Zviera", "Brok", "Zviera Default", 5, false, false, 0.1f);
            zviera.info();
            zviera.VydajZvuk();

            Console.WriteLine();

            Pes pes = new Pes("Pes","Dunco","Vlciak", 3, true, true, 0.4f,10);
            pes.info();
            pes.stekaj();
            pes.stekaj();
            pes.VydajZvuk();

            Console.WriteLine();

            Macka macka = new Macka("Macka","Elza", "Britska zlata", 8, true, true, 0.6f, 8.5f);
            macka.info();
            macka.Mnaukaj();
            macka.VydajZvuk();

            Console.ReadKey();
        }
    }

    
}
