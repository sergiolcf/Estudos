using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor {
    class Program {
        static void Main(string[] args) {

            Produto produto;


            Console.WriteLine("Insira os dados do Produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço R$ ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade ");
            int qtde = int.Parse(Console.ReadLine());

            produto = new Produto(nome, preco, qtde);

            Console.WriteLine("Dados do produto {0}", produto.ToString());
            Console.WriteLine();

            Console.WriteLine("Digite o número de Produtos para Adicionar ao estoque");
            int qtdeProduto = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(qtdeProduto);
            Console.WriteLine("Dados do produto {0}", produto.ToString());
            Console.WriteLine();

            Console.WriteLine("Digite o número de Produtos para Remover ao estoque");
            int removProduto = int.Parse(Console.ReadLine());


          

            produto.RemoverProdutos(removProduto);
            Console.WriteLine("Dados do produto {0}", produto.ToString());

        }
    }
}
