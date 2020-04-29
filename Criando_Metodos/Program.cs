using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_Metodos {
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

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("AreaX = {0}", areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("AreaY = {0}", areaY.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
