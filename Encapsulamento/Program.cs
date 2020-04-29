using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("Tv", 500.00, 10);

            p.SetNome("TvPlasma");

            Console.WriteLine(p);

        }
    }
}
