using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Tres_Atributos {
    class Program {
        static void Main(string[] args) {
            Triangulo x, y;


            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com os valores do Triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            Console.WriteLine("Entre com os valores do Triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("AreaX = {0}",areaX);
            Console.WriteLine("AreaX = {0}", areaY);


        }
    }
}
