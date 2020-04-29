using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_Dados {
    class Program {
        static void Main(string[] args) {
            //Parte 1
            /*
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Voce Digitou");
         
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            */

            //Prt2

            /* int n1 = int.Parse(Console.ReadLine());
             char ch = char.Parse(Console.ReadLine());
             double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             string[] vet = Console.ReadLine().Split(' ');
             string nome = vet[0];
             char sexo = char.Parse(vet[1]);
             int idade = int.Parse((vet[2]));
             double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);




             Console.WriteLine("Você ditiou");
             Console.WriteLine(n1);
             Console.WriteLine(ch);
             Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
             Console.WriteLine(nome);
             Console.WriteLine(sexo);
             Console.WriteLine(idade);
             Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));*/

            //Exc Prt2

            Console.WriteLine("Nome Completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int q = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor do Violão?");
            double v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Altura e Idade?");
            string[] vet = Console.ReadLine().Split(' ');

            double alt = double.Parse(vet[0], CultureInfo.InvariantCulture);
            int ida = int.Parse(vet[1]);

            Console.WriteLine("Resultados...");
            Console.WriteLine(nome);
            Console.WriteLine(q);
            Console.WriteLine(v.ToString(), CultureInfo.InvariantCulture);
            Console.WriteLine(alt.ToString(), CultureInfo.InvariantCulture);
            Console.WriteLine(ida);

        }
    }
}
