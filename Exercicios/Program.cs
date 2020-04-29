using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios {
    class Program {
        static void Main(string[] args) {


            #region Exercicio Array
            //Console.WriteLine("Quantos quartos irão alugar?");
            //int qnt = int.Parse(Console.ReadLine());

            //Rooms[] quartos = new Rooms[10];

            //for (int i = 0; i < qnt; i++) {

            //    Console.WriteLine("Nome");
            //    string nome = Console.ReadLine();

            //    Console.WriteLine("E-mail");
            //    string email = Console.ReadLine();

            //    Console.WriteLine("Número do Quarto");
            //    int q = int.Parse(Console.ReadLine());

            //    quartos[q] = new Rooms { Name = nome, Email = email, Quarto = q };

            //}

            //for (int i = 0; i < quartos.Length; i++) {

            //    if (quartos[i] != null) {

            //        Console.WriteLine(quartos[i]);
            //    }

            //}
            #endregion

            #region Exercicio Lista 1

            //int numEmployees, idEmployee, searchEmployee;
            //string nameEmployee;
            //double salaryEmployee, percentage;


            //Console.WriteLine("How many employee will be registered?");
            //numEmployees = int.Parse(Console.ReadLine());

            //List<Employee> listEmp = new List<Employee>();

            //for (int obj = 0; obj < numEmployees; obj++) {

            //    Console.Write("ID.: ");
            //    idEmployee = int.Parse(Console.ReadLine());
            //    Console.Write("Name.: ");
            //    nameEmployee = Console.ReadLine();
            //    Console.Write("Salary.: ");
            //    salaryEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    listEmp.Add(new Employee(idEmployee, nameEmployee, salaryEmployee));
            //}

            //Console.Write("Enter the employee Id that will have salary increase.: ");
            //searchEmployee = int.Parse(Console.ReadLine());


            //Employee emp = listEmp.Find(x => x.ID == searchEmployee);
            //if (emp != null) {
            //    Console.Write("Enter the percentage: ");
            //    percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    emp.IncreaseSalary(percentage);
            //}
            //else {
            //    Console.WriteLine("This id does not exist!");
            //}

            //foreach (var item in listEmp) {
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Exercicio Matriz

            //Console.Write("Informe Número de Linhas.: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Informe Número de Colunas.: ");
            //int columns = int.Parse(Console.ReadLine());

            //int[,] mat = new Matriz().DoneMatriz(rows, columns);

            //Console.WriteLine("Digite um número");
            //int n = int.Parse(Console.ReadLine());

            //Matriz.DoneExercises(mat, n);

            #endregion

            #region Exercicio Conjunto

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            int alunos, cods, total = 0;
            
            Console.WriteLine("O Curso A Possui quantos alunos? ");
            alunos = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite os códigos dos alunos do curso A");
            for (int i = 0; i < alunos; i++) {
                cods = int.Parse(Console.ReadLine());
                A.Add(cods);
            }


            Console.WriteLine("O Curso B Possui quantos alunos? ");
            alunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A");
            for (int i = 0; i < alunos; i++) {
                cods = int.Parse(Console.ReadLine());
                B.Add(cods);
            }
            Console.WriteLine("O Curso C Possui quantos alunos? ");
            alunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A");
            for (int i = 0; i < alunos; i++) {
                cods = int.Parse(Console.ReadLine());
                C.Add(cods);
            }

            A.ExceptWith(B);
            A.UnionWith(B);
            A.ExceptWith(C);
            A.UnionWith(C);

            Console.WriteLine("-----------------------------------------");

         
            foreach (var item in A) {
                total += 1;
            }
            Console.WriteLine($"Total de Alunos {total}");
            #endregion
        }
    }
}
