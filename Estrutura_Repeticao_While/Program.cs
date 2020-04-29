using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estrutura_Repeticao_While {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um número..");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(num >= 0.0) {

                double raiz = Math.Sqrt(num);
                Console.WriteLine("A raiz quadrada de {0} é = {1}", num, raiz.ToString("F3",CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número...");
                 num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número Negativo!!");



        }
    }
}
