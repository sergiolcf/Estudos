using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    class Produto {
        private string Nome;
        private double Preco;
        private int Quantidade;

        public Produto (string Nome, double Preco, int Quantidade) {

            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }

        public string GetNome() {

            return Nome;
        }

        public void SetNome(string nome) {

            if(nome != null && nome.Length > 1) {
                this.Nome = nome;
            }
         
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
