using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolvendo_Problema_Estoque {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque() {

            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int q) {

            Quantidade += q;
         }

        public void RemoverProdutos(int q) {

            Quantidade -= q;
        }

        public override string ToString() {
            return Nome
                + ", R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$"
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
