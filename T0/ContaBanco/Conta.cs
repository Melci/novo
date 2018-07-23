using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Cliente { get; set; }
        public virtual void Sacar(double ValorSaque)
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
        public virtual void Depositar(double ValorDeposito)
        {
        if (ValorDeposito > 0)
            {
                this.Saldo += ValorDeposito;
            }
        }
        public void Transfere(double Valor, Conta Destino)
        {
            if (Valor <= this.Saldo && Valor > 0)
            {
                this.Sacar(Valor);
                Destino.Depositar(Valor);
            }
        }
    }
}
   
