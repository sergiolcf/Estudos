using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio {
    class Conta {

        //atributos privados
        private double taxa = 5.00;
        //Auto Properties
        public string Nome { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }

               //Construtores
        public Conta(string titular, int numConta){

            Nome = titular;
            NumeroConta = numConta;
                  
            }

        public Conta(string titular, int numConta, double depositoInicial) : this(titular, numConta) {
            Deposito = depositoInicial;
        }

        //Métodos
        public double Deposito {

            set { Saldo += value; }
        }

        public double Saque {

            set {

                Saldo -= value;
                Saldo -= taxa;
            }
        }


          //ToString()
        public override string ToString() {

            return "Conta: "
                + NumeroConta.ToString()
                + ", Titular: "
                + Nome
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }

}