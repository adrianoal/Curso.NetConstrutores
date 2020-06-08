using System;
using System.Globalization;

namespace EstoqueProdutosAula42
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Entre com os dados do Produto: ");
            Console.WriteLine(String.Empty);

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Empty);

            Produto p = new Produto(nome, preco, quantidade);
           
            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine(string.Empty);// Quebra de linha

            // ADICIONADO NO ESTOQUE ESTOQUE
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);

            Console.WriteLine(); // Quebra de linha 
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            // ADICIONADO NO REMOVIDO DO ESTOQUE
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtde);

            Console.WriteLine(); // Quebra de linha 
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

        }
    }
}