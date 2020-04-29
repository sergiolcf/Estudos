using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade) {

            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome {

            get { return _nome; }

            set {

                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public int Quantidade {
            get { return _quantidade; }

        }

        public double ValorTotalEstoque {

            get { return _preco * _quantidade; }
        }

        public int AdicionarProduto {

            set { _quantidade += value; }
        }

        public int RemoverProduto {

            set { _quantidade -= value; }
        }

        public override string ToString() {
            return Nome
                + ", R$"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: R$"
                + ValorTotalEstoque;
        }
    }
}
