using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificador_Ref_Out {
    class Calculator {

        public static int Triple(int x, out int result) {

            result = x;

            return result *= 3;

        }
    }
}
