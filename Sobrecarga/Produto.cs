using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {

        }

        public Produto (string nome, double preco, int qtde) {

            Nome = nome;
            Preco = preco;
            Quantidade = qtde;
        }

        public Produto (string nome, double preco) {

            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

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
