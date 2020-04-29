using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalavraThis {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {
            Quantidade = 0;
        }

        public Produto (string Nome, double Preco, int Quantidade) {

            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }

        public Produto (string nome, double preco) : this() {

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
