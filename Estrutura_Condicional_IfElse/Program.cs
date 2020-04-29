using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Condicional_IfElse {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com um número Inteiro..");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0) {
                Console.WriteLine("{0} é Par!", n1);
            }
            else {
                Console.WriteLine("{0} é Impar", n1);
            }
        }
    }
}
