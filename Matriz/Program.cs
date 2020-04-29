using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz {
    class Program {
        static void Main(string[] args) {

            //double[,] mat = new double[2, 3];

            //Console.WriteLine(mat.Length);
            //Console.WriteLine(mat.Rank);
            //Console.WriteLine(mat.GetLength(0));
            //Console.WriteLine(mat.GetLength(1));


            Console.Write("Informe número de linhas x Colunas.: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int l = 0; l < n; l++) {

                string[] vet = Console.ReadLine().Split(' ');

                for (int c = 0; c < n; c++) {

                    mat[l, c] = int.Parse(vet[c]);

                }
            }


            //Diagonal
            Console.WriteLine("Main diagonal");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();


            //Negativos
            Console.WriteLine("Negativos");
            for (int l = 0; l < n; l++) {

                for (int c = 0; c < n; c++) {

                    if(mat[l,c] < 0)
                        Console.Write(mat[l,c] + " ");

                }

            }
        }

      
    }
}
