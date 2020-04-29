using System;
using System.Collections.Generic;

namespace Listas {
    class Program {
        static void Main(string[] args) {

            List<string> lista = new List<string>();

            //Inserir Elemento na Lista (Add/Insert)
            Console.WriteLine("---------------------");
            Console.WriteLine("Inserir Elemento na Lista (Add/Insert)");
            lista.Add("Sergio");
            lista.Add("Luis");
            lista.Add("Coutinho");
            lista.Add("Ferreira");
            lista.Insert(2,"Marcela");
            Console.WriteLine("---------------------");
            foreach (var item in lista) {

                Console.WriteLine(item);

            }
            Console.WriteLine();

        
            //Contar tamanho da Lista
            Console.WriteLine("---------------------");
            Console.WriteLine("Contar tamanho da Lista");
            Console.WriteLine("Tamanho da itens da lista.: {0}", lista.Count);
            Console.WriteLine("---------------------");
            Console.WriteLine();

            //Encontrar PRIMEIRA ou ULTIMA ELEMENTOS da lista que satisfaça um predicado (Usando expressao Lambda)
            //Lambda
            Console.WriteLine("---------------------");
            Console.WriteLine("Encontrar PRIMEIRA ou ULTIMA ELEMENTOS da lista que satisfaça um predicado (Usando expressao Lambda)");
            string s1 = lista.Find(x => x[0] == 'M');
            string s2 = lista.FindLast(x => x[0] == 'F');
            Console.WriteLine("First M.: {0}",s1);
            Console.WriteLine("Last F.: {0}", s2);
            Console.WriteLine("---------------------");
            Console.WriteLine();

            //Encontrar PRIMEIRA ou ULTIMA POSIÇÃO da lista que satisfaça um predicado (Usando Lambda)
            Console.WriteLine("---------------------");
            Console.WriteLine("Encontrar PRIMEIRA ou ULTIMA POSIÇÃO da lista que satisfaça um predicado (Usando Lambda)");    
            int n1 = lista.FindIndex(x => x[0] == 'S');
            int n2 = lista.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine("---------------------");
            Console.WriteLine();

            //Filtar a Lista com base em um Predicado
            Console.WriteLine("---------------------");
            Console.WriteLine("Filtar a Lista com base em um Predicado");
            List<string> lista2 = lista.FindAll(x => x.Length == 7);
            foreach (var obj in lista2) {
                Console.WriteLine(obj);

            }
            Console.WriteLine("---------------------");
            Console.WriteLine();


            //Remover Elementos da Lista
            Console.WriteLine("---------------------");
            Console.WriteLine("Remover Elementos da Lista");
            //lista.Remove("Luis");
            //lista.RemoveAll(x => x[0] == 'S');
            // lista.RemoveAt(1);
            lista.RemoveRange(0, 2);
            foreach (var obj in lista) {
                Console.WriteLine(obj);

            }
            Console.WriteLine("---------------------");
            Console.WriteLine();



        }
    }
}
