using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Classes {
    class ConversorMoeda {

        public static int Iof = 6;

        public static double Conversor(double dolar, double cota) {
            double total = dolar * cota;
            return total *  Iof / 100.0;
        }
    }
}
