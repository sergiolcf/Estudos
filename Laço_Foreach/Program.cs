using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laço_Foreach {
    class Program {
        static void Main(string[] args) {

            string[] vect = { "Sergio", "Luis", "Coutinho", "Ferreira" };

            foreach (var item in vect) {

                Console.WriteLine(item);

            }
        }
    }
}
