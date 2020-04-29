using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes_Sintaxe {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite três Números...");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.Write("O Maior = {0}", resultado);
        }

        static int Maior (int a, int b, int c) {

            int n;

            if(a > b && a > c) {
                n = a;
            } else if(b > c) {
                n = b;
            }
            else {
                n = c;
            }

            return n;
        }
    }
}
