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
            if (ValorSaque <= 0.0)
            {
                throw new ArgumentException();
            }
            if (ValorSaque > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= ValorSaque;
            }
        }
    }
}
