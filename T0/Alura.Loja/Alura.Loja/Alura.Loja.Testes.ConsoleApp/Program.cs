using Microsoft.EntityFrameworkCore.ChangeTracking;
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
            var paofrances = new Produto();
            paofrances.Nome = "Pão Francês";
            paofrances.PrecoUnitario = 0.40;
            paofrances.Unidade = "Unidade";
            paofrances.Categoria = "Padaria";

            var compra = new compra();
            compra.Quantidade = 6;
            compra.Produto = paofrances;
            compra.Preco = paofrances.PrecoUnitario * compra.Quantidade;
        }
    }
}
