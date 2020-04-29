using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto
{
    class Program
    {
        static void Main(string[] args) {


            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);


            //B.Remove(3);

            //A.ExceptWith(B);
            //A.UnionWith(B);
            A.IntersectWith(B);


            Console.WriteLine(A);


            foreach (var item in A) {

                Console.WriteLine(item);
            }

            foreach (var item in B) {
                Console.WriteLine(item);
            }

            Console.WriteLine("Digite um valor inteiro.: ");
            int n = int.Parse(Console.ReadLine());

            if(B.Contains(n))
                Console.WriteLine($"O Numero.: {n}, pertence ao Conjunto B");
            else if (A.Contains(n))
                Console.WriteLine($"O Numero.: {n}, pertence ao conjunto A");

           


        }
    }
}
