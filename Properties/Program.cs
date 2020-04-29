using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("Tv", 500.00, 10);


            p.Nome = "TV 5k";
            p.RemoverProduto = 3;
    
            


            Console.WriteLine(p);

        }
    }
}
