using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolvendo_Problema_Estoque {
    class Program {
        static void Main(string[] args) {

            Produto produto;

            produto = new Produto();

            Console.WriteLine("Insira os dados do Produto");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço R$ ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade ");
            produto.Quantidade = int.Parse(Console.ReadLine());

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
