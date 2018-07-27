namespace Alura.Loja.Testes.ConsoleApp
{
    internal class compra
    {
      
        public int Id { get; internal set; }
        public int Quantidade { get; internal set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; internal set; }
        public double Preco { get; internal set; }
    }
}