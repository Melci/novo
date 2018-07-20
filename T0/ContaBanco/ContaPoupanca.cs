using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
    class ContaPoupanca : Conta
    {
        public override void Sacar(double ValorSaque)
        {
            this.Saldo -= ValorSaque - 0.1;
        }
        public override void Depositar(double ValorDeposito)
        {
            this.Saldo += ValorDeposito + 0.1;
        }
    }
}
