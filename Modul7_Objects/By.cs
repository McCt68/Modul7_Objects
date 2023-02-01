using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7_Objects
{
    internal class By
    {
        private string navn;
        private int indbyggerAntal;

        // Constructor der initaliserer navn og sætter den private til samme as initialiseret
        public By(string _navn)
        {
            navn = _navn;

            Console.WriteLine("Oprettet by: {0} med first Constructor", navn);
        }

        // Second Constructor
        public By(string _navn, int _indbyggerAntal)
        {
            navn = _navn;
            indbyggerAntal = _indbyggerAntal;

            Console.WriteLine($"Oprettet by: {navn}, antal indbyggere: {indbyggerAntal}. Med second Constructor");
        }
    }
}
