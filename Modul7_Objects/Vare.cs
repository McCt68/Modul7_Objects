using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7_Objects
{
    internal class Vare
    {
        public string vare;
        public double pris;

        public void Udskriv()
        {
            Console.WriteLine($"Vare Navn: {vare} - Pris: {pris} Kr.");
        }
    }

    internal class KasseApperat : Vare
    {

        // En måde at gøre det på
        public void UdskrivBon(Vare[] vare)
        {

            double totalPris = 0;

            foreach (Vare v in vare)
            {
                Console.WriteLine($"{v.vare} - {v.pris} Kr.");
                totalPris += v.pris;
            }

            // C2 - will represent as Kr.
            Console.WriteLine("\nSamlet beløb i alt {0:C2}", totalPris);
        }

        // En anden måde hvor jeg bruger metoden fra vare classen
        // Samt indsat dato for indkøb
        public void UdskrivBonMedMethode(Vare[] vare)
        {
            double totalPris = 0;
            DateTime currentDate = DateTime.Now;

            Console.WriteLine("\n******************************************");
            Console.WriteLine($"Ny bon. - {currentDate}\n");
            foreach (Vare v in vare)
            {
                
                totalPris += v.pris;
                v.Udskriv();
            }
            Console.WriteLine("\nSamlet beløb i alt {0:C2}", totalPris);

        }
    }
}
