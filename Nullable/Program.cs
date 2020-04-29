using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args) {

            // Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y);
            Console.WriteLine(y.HasValue);
            Console.WriteLine(y.Value);

            if(x.HasValue)
            Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            //Operador de coalescência Nula
            double t = x ?? 0.9;
            Console.WriteLine(t);



        }
    }
}
