using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBanco
{
    public partial class Form1 : Form
    {
        Conta[] contas;
        private Conta Conta;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[2];

            contas[0] = new Conta();
            contas[0].NumeroConta = 1;
            contas[0].Cliente = new Cliente("Vanessa Silva");

            contas[1] = new Conta();
            contas[1].NumeroConta = 2;
            contas[1].Cliente = new Cliente("Melci Victor");
            
            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Cliente.Nome);
                destinoDaTransferencia.Items.Add(conta.Cliente.Nome);
            }
        }
        private void btnDeposita_Click(object sender, EventArgs e)
        {
            string ValorDoDeposito = txtValor.Text;
            double valorDeposito   = Convert.ToDouble(ValorDoDeposito);
            Conta contaIndice = this.BuscaContaSelecionada();
            contaIndice.Depositar(valorDeposito);
            this.MostraConta();
        }
        private void MostraConta()
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();
            
            textoTitular.Text = contaSelecionada.Cliente.Nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoNumeroConta.Text = Convert.ToString(contaSelecionada.NumeroConta);
            txtValor.Clear();
            txtValor.Select();
        }
        private void btnSacar_Click(object sender, EventArgs e)
        {
            string ValorDoSaque   = txtValor.Text;
            double valorSacado    = Convert.ToDouble(ValorDoSaque);
            Conta contaIndice = this.BuscaContaSelecionada();

            try
            {
                contaIndice.Sacar(valorSacado);
                MessageBox.Show("Saque Liberado");
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Valor do saque inválido.");
            }
            MostraConta();
        }
       
        private Conta BuscaContaSelecionada() 
        {
            int indiceContas = comboContas.SelectedIndex;
            return this.contas[indiceContas];
        }
        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostraConta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Conta contaSelecionada = this.BuscaContaSelecionada();
                int indiceDaContaDestino = destinoDaTransferencia.SelectedIndex;
                Conta contaDestino = this.contas[indiceDaContaDestino];
                string textoValor = txtValor.Text;
                double valorTransferencia = Convert.ToDouble(textoValor);

                contaSelecionada.Transfere(valorTransferencia, contaDestino);

                MostraConta();
            }
        }
        private void destinoDaTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTeste_Click(object sender, EventArgs e)
        {

        }
    }
}
