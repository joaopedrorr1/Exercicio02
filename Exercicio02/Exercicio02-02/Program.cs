using Exercicio02_02.Entities;
using Exercicio02_02.Repositories;
using Exercicio02_02.Utils;
using System;

namespace Exercicio02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n - EXPORTAÇÂO DE DADOS DE PRODUTO - \n");

            try
            {
                var produto = new Produto();

                produto.IdProduto = ConsoleUtil.ReadInt("Id do Produto: ");
                produto.Nome = ConsoleUtil.ReadText("Nome do Produto: ");
                produto.Preco = ConsoleUtil.ReadDouble("Preço: ");
                produto.Quantidade = ConsoleUtil.ReadInt("Quantidade: ");

                produto.Categoria = new Categoria();

                produto.Categoria.IdCategoria = ConsoleUtil.ReadInt("Id do Departamento: ");
                produto.Categoria.Descricao = ConsoleUtil.ReadText("Nome: ");

                var produtoRepository = new ProdutoRepository();
                produtoRepository.ExportarJSON(produto);

                Console.WriteLine("\nJSON gerado com sucesso.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.ReadKey(); //pausar
        }
    }
}
