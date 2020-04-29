using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio_For {
    class Program {
        static void Main(string[] args) {
            #region Exercicio 1

            /*Exercício 01
            Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1067/uri1067/Program.cs
            Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            X, se for o caso.

            Console.WriteLine("Digite um número");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                if (!(i % 2 == 0)) {

                    Console.WriteLine(i);
                }
            }*/

            #endregion

            #region Exercicio 2
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            Console.WriteLine("Digite um Valor: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++) {

              if( i >= 10 && i <= 20) {

                    Console.WriteLine("{0} in", i);
                }
                else {
                    Console.WriteLine("{0} out", i);
                }

            } */
            #endregion

            #region Exercicio 3
            /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5.

            Console.WriteLine("Digite Valor");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Digite as notas");
                string[] linha = Console.ReadLine().Split(' ');
                double a = double.Parse(linha[0], CultureInfo.InvariantCulture);
                double b = double.Parse(linha[0], CultureInfo.InvariantCulture);
                double c = double.Parse(linha[0], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine("Media.: {0}",media.ToString("F1", CultureInfo.InvariantCulture));

            }*/
            #endregion

            #region Exercicio 4
            /*Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

            Console.WriteLine("Digite a quantidade de números..");
            int n = int.Parse(Console.ReadLine());
            int contagem = 1;
            string resultado;
            for (int i = 0; i < n; i++) {

                Console.WriteLine("Insira os {0} numeros  Pares..", contagem);
                string[] ns = Console.ReadLine().Split(' ');
                double a = double.Parse(ns[0]);
                double b = double.Parse(ns[1]);
                double div = a / b;
                if(div <= 0.0) {
                    resultado = "Divisão Impossível";
                }
                else {

                    resultado = div.ToString();
                }
                Console.WriteLine("Resultado da divisão de {0} / {1} = {2}", a, b, resultado);
                contagem += 1;
            }
            */
            #endregion

            #region Exercicio 5
            /*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            Lembrando que, por definição, fatorial de 0 é 1.

            Console.WriteLine("Insira o valor");
            int n = int.Parse(Console.ReadLine());
            int fat = 1;
            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }
            Console.WriteLine("Fatorial de {0} = {1}", n, fat);*/
            #endregion

            #region Exercicio 6
            /*Ler um número inteiro N e calcular todos os seus divisores.

            Console.WriteLine("Informe um valor");
            int n = int.Parse(Console.ReadLine());
            int resultado;
            for (int i = 1; i <= n; i++) {

                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            }*/
            #endregion

            #region Exercicio 7
            /*Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            exemplo.

            Console.WriteLine("informe valor");
            int n = int.Parse(Console.ReadLine());
            int pot2, pot3;
            

            for (int i = 1; i <=n; i++) {
                pot2 = i * i;
                pot3 = i * i * i;
                Console.WriteLine();
                Console.Write("{0}-{1}-{2}", i, pot2, pot3);
                Console.WriteLine();
            }
            */

            #endregion

        }

    }
}
