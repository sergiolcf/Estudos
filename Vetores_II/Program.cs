using System;
using System.Globalization;

namespace Vetores_II {
    class Program {
        static void Main(string[] args) {

            double sum = 0.0;

            Console.WriteLine("Digite a quantidade de produtos");
            int qnt = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[qnt];

            for (int i = 0; i < qnt; i++) {
                vect[i] = new Produto();
                Console.WriteLine("Nome do Produto");
                vect[i].Name = Console.ReadLine();
                Console.WriteLine("Preço do Produto");
                vect[i].Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }

            for (int i = 0; i < qnt; i++) {

                sum += vect[i].Price / 3;

            }

            Console.WriteLine("Average = {0}", sum);
        }
    }
}
