using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
    class Cliente
    {
        public string Nome;
        public string CPF;
        public string RG;
        public int    Idade;
        public string Endereco;
        public bool MaiorDeIdade()
        {
            return this.Idade >= 18;
        }
        public Cliente (String Nome)
        {
            this.Nome = Nome;
        }
    }
}
