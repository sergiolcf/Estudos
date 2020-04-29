using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificador_Ref_Out {
    class Program {
        static void Main(string[] args) {


            int a = 10;
            int b;
            Calculator.Triple(a, out b);
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
