using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Insira o número de Vetores");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {

                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {

                sum += vect[i];

            }

            double avg = sum / n;
            Console.WriteLine("A media é.: {0}", avg);
           
        }
    }
}
