using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
    class ContaCorrente : Conta
    {
        public override void Sacar(double ValorSaque)
        {
            this.Saldo -= ValorSaque - 0.1;
        }
    }
}
