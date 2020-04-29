using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios {
    class Matriz {


        public int[,] Mat { get; set; }



        public int[,] DoneMatriz(int c, int l) {

            int[,] mat = new int[c, l];

            Console.WriteLine("Digite os números da Matriz");
            for (int i = 0; i < c; i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < l; j++) {

                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Mat = mat;
            return mat;
        }

        public static void DoneExercises(int[,] m, int n) {



            for (int i = 0; i < m.GetLength(0); i++) {

                for (int j = 0; j < m.GetLength(1); j++) {

                    if (m[i, j] == n) {

                        Console.Write("Posição.: {0},{1} ", i, j);
                        Console.WriteLine();
                    }
                }


            }
        }
    }
}


 //if (j > 0) {
 //                           Console.WriteLine("Left: " + mat[i, j - 1]);
 //                       }
 //                       if (i > 0) {
 //                           Console.WriteLine("Up: " + mat[i - 1, j]);
 //                       }
 //                       if (j<n - 1) {
 //                           Console.WriteLine("Right: " + mat[i, j + 1]);
 //                       }
 //                       if (i<m - 1) {
 //                           Console.WriteLine("Down: " + mat[i + 1, j]);
 //                       }