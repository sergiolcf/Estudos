using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Classes {
    class Funcionario {

        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido() {

            return Salario - Imposto;
        }

        public void AumentarSalario(double imp) {

            Salario +=  (Salario * imp) / 100;

        }

        public override string ToString() {
            return Nome
                    + ", R$ "
                    + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
