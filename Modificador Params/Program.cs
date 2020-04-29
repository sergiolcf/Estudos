using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificador_Params {
    class Program {
        static void Main(string[] args) {


            int s1 = Calculator.Sum(2, 3, 4, 5, 6);
            int s2 = Calculator.Sum(1, 2, 3, 4, 5, 4, 3, 2, 1, 4, 54, 5, 67);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
