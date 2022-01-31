using System;
using System.Globalization;

namespace OBJMERCADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            Console.WriteLine("dados do produto");
            Console.Write("nome: ");
            produto1.nome   = Console.ReadLine();
            Console.Write("preço: ");
            produto1.preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("quantidade em estoque :");
            produto1.quant = int.Parse(Console.ReadLine());
            Console.WriteLine(produto1.nome+",R$"+produto1.preco +","+produto1.quant+", R$"+produto1.ValorTotal()) ;//OU (produto1)
            Console.Write("adicionar ao estoque :");
            int quat = int.Parse(Console.ReadLine());
            produto1.AdicionarProduto(quat);
            Console.WriteLine(produto1);
            Console.Write("remover do estoque :");
             quat = int.Parse(Console.ReadLine());
            produto1.RemoverProduto(quat);
            Console.WriteLine(produto1);
        }
    }
}
