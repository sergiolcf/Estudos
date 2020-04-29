using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao_Implicita_Casting {
    class Program {
        static void Main(string[] args) {

            //Conversão implicita de Tipos
            float x = 4.5F; // 4 bytes
            double y = x; // 8 bytes

            //Conversão em Casting
            double a; // 8 bytes
            float b; // 4 bytes
            a = 5.1;
            b = (float)a;

            int c;
            c = (int)a;

            int j = 5;
            int t = 2;

            double res = (double)a / b;
            Console.WriteLine(res);
        }
    }
}
