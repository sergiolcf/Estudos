using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade) {

            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {

            get { return _nome; }

            set {

                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

    public double ValorTotalEstoque {

        get { return Preco * Quantidade; }
    }

    public int AdicionarProduto {

        set { Quantidade += value; }
    }

    public int RemoverProduto {

        set { Quantidade -= value; }
    }

    public override string ToString() {
        return Nome
            + ", R$"
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: R$"
            + ValorTotalEstoque.ToString("F2", CultureInfo.InvariantCulture);
    }
}
}
