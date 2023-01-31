using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7_Objects
{
    internal class Person
    {
        public string navn = "";
        public string eMail = "";

        public void printPersonInformation()
        {
            Console.WriteLine("Navn: {0}", navn);
            Console.WriteLine("EMail: {0}", eMail);
        }
    }
}
