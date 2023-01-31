using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7_Objects
{
    internal class Matematik
    {


        // 7.2 - Misforstod opgaven, her er det lavet som Constructor og ikke en method
        public Matematik(string tal)
        {
            Console.WriteLine("Tallet du indgav som parameter var {0}", tal);
        }

        // 7.3
        public void LægSammen(int talEt, int talTo)
        {
            int sum = talEt + talTo;
            Console.WriteLine("De to tal {0} + {1} lagt sammen giver {2}.", talEt, talTo, sum);
        }

        // 7.4
        public int TrækFra(int talEt, int talTo)
        {
            return talEt - talTo;
        }

        // 7.5
        private int total = 0;
        public void PlusTotal(int talEt)
        {
            total = total + talEt;
            
        }

        public void Sum()
        {
            Console.WriteLine($"summen er nu: {total}");
        }
    }
}
