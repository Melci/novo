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

            using (var repo = new LojaContext())
            {
                Produto primeiro = repo.Produtos.First();
                primeiro.Nome = "Harry Potter - Editado";
                repo.Produtos.Update(primeiro);
                repo.SaveChanges();
            }
            RecuperaProduto();
        }

        private static void ExcluirProdutos()
        {
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach(var item in produtos)
                {
                    repo.Produtos.Remove(item);
                }
                repo.SaveChanges();
            }
        }

        private static void RecuperaProduto()
        {
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
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

            Produto p2 = new Produto();
            p2.Nome = "O Simbolo perdido";
            p2.Categoria = "Livros";
            p2.Preco = 10.00;

            using (var Contexto = new LojaContext())
            {
                Contexto.Produtos.AddRange(p, p2);
                Contexto.SaveChanges();
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
