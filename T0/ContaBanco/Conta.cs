using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
    public abstract class Conta
    {
        public int NumeroConta { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; protected set; }
        public String Cliente;
        public abstract void Sacar(double ValorSaque);
       
        public virtual void Depositar(double ValorDeposito)
        {
            if (ValorDeposito <= 0 )
            {
                throw new ArgumentException();
            }
            else
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
   
