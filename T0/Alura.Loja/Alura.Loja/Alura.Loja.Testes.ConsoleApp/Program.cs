using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // GravarUsandoAdoNet();
            //GravarUsandoEntity();
            //RecuperaProduto();
            //ExcluirProdutos();
            //RecuperaProduto();
            AtualizarProduto();
        }

        private static void AtualizarProduto()
        {
            GravarUsandoEntity();
            RecuperaProduto();

            using (var repo = new ProdutoDaoEntity())
            {
                Produto primeiro = repo.Produtos().First();
                primeiro.Nome = "Harry Potter - Editado";
                repo.Atualizar(primeiro);
            }
            RecuperaProduto();
        }

        private static void ExcluirProdutos()
        {
            using (var repo = new ProdutoDaoEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                foreach(var item in produtos)
                {
                    repo.Remover(item);
                }
            }
        }

        private static void RecuperaProduto()
        {
            using (var repo = new ProdutoDaoEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                Console.WriteLine("Foram Encontrados {0} produto(s).", produtos.Count);
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var Contexto = new ProdutoDaoEntity())
            {
                Contexto.Adicionar(p);
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}
