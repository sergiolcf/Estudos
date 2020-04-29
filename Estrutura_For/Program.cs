using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_For {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Quantos Números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= n; i++) {
                Console.Write("Valor :#{0} ",i);
                int valor = int.Parse(Console.ReadLine());

                soma += valor;

            }

            Console.WriteLine("Soma = {0}", soma);
        }
    }
}
