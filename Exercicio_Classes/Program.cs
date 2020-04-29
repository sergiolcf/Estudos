using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Exercicio_Classes {
    class Program {
        static void Main(string[] args) {

            #region Exercicio 1
            /*Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
            velha.
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Informe nome Pessoa 1");
            string nomePessoa1 = Console.ReadLine();
            Console.WriteLine("Informe idade Pessoa 1");
            int idadePessoa1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe nome Pessoa 2");
            string nomePessoa2 = Console.ReadLine();
            Console.WriteLine("Informe idade Pessoa 2");
            int idadePessoa2 = int.Parse(Console.ReadLine());

            if(idadePessoa1 > idadePessoa2) {
                Console.WriteLine("{0}, é a pessoa mais velha", nomePessoa1);
            }
            else {
                Console.WriteLine("{0}, é a pessoa mais velha", nomePessoa2);
            }
            */


            #endregion

            #region Exercicio 2
            /*Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            médio dos funcionários.

            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Informe Funcionario 1");
            string func1 = Console.ReadLine();
            Console.WriteLine("Informe Salário Funcionário 1");
            double salario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe Funcionario 2");
            string func2 = Console.ReadLine();
            Console.WriteLine("Informe Salário Funcionário 2");
            double salario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double mediaSalario = (salario1 + salario2) / 2;

            Console.WriteLine("A media dos sálários = {0}", mediaSalario.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Exercicio 4
            /*Fazer um programa para ler os valores da largura e altura de um retângulo. Em
            seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
            como mostrado no projeto ao lado.

            Retangulo retangulo;

            retangulo = new Retangulo();

            Console.WriteLine("Entre com Altura e Largura do Retangulo");
            Console.Write("Largura = ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura = ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(retangulo);
            */
            #endregion

            #region Exercicio 5
            /*Fazer um programa para ler os dados de um funcionário (nome,
            salário bruto e imposto). Em seguida, mostrar os dados do
            funcionário (nome e salário líquido). Em seguida, aumentar o salário
            do funcionário com base em uma porcentagem dada (somente o
            salário bruto é afetado pela porcentagem) e mostrar novamente os
            dados do funcionário. Use a classe projetada abaixo.
            Funcionario func;

            func = new Funcionario();

            Console.Write("Nome do Funcionario ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário do Funcionario ");
            func.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario {0}",func);
            Console.Write("Digite a porcentagem de aumento do salário ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(imposto);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados {0}",func);
            */
            #endregion

            #region Exercicio 6
            /*Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
            ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
            para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
            este problema.*/
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = "
            + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }


            #endregion

            #region Exercicio 7
            /*Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
            uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
            que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
            para ser responsável pelos cálculos.*/

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = ConversorMoeda.Conversor(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

            #endregion
        }
}
} 
