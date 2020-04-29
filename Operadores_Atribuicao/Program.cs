using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Atribuicao {
    class Program {
        static void Main(string[] args) {

            /* int a = 10;
            Console.WriteLine(a);
            a += 2;
            Console.WriteLine(a);
            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);
            s+= "DEF";
            Console.WriteLine(s);*/

            int a = 10;
            a++;
            int b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
