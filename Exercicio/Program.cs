using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {

            // Digitar o número da conta, nome, e perguntar se fraz deposito inicial.
            //Mostrar na tela o resultado
            //Pedir deposito na conta
            //PEdir saque da conta
            //taxa para saque de R$ 5.00

            string depositoInicio, nomeTitular;
            int numeroConta;

          

            Console.WriteLine("Nome do titular da conta");
            nomeTitular = Console.ReadLine();
            Console.WriteLine("Informe o número da conta");
            numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Deseja fazer um depósito inicial?");
            depositoInicio = Console.ReadLine();

            Conta conta = new Conta(nomeTitular, numeroConta);

            if (depositoInicio == "s") {

                Console.WriteLine("Informe o valor do Depósito Inicial");
                conta.Deposito = double.Parse(Console.ReadLine());
            }
            else {
                Console.WriteLine(conta);

            }

            Console.WriteLine("Informe o valor para Depósito");
            conta.Deposito = double.Parse(Console.ReadLine());

            Console.WriteLine(conta);

            Console.WriteLine("Informe o valor para Saque");
            conta.Saque = double.Parse(Console.ReadLine());

            Console.WriteLine(conta);




        }
    }
}
