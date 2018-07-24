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
        private Conta[] contas;
        public int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[1];
            this.contas[0] = new ContaCorrente();
        }

        public void AdicionaConta(Conta conta)
        {
            if (this.numeroDeContas == this.contas.Length)
            {
                Conta[] novaConta = new Conta[this.contas.Length * 2];
                for (int indice = 0; indice < this.numeroDeContas; indice++)
                {
                    novaConta[indice] = this.contas[indice];
                }
                this.contas = novaConta;
            }
            contas[numeroDeContas] = conta;
            numeroDeContas++;
            comboContas.Items.Add(conta.Cliente);
            destinoDaTransferencia.Items.Add(conta.Cliente);
        }

        private void btnDeposita_Click(object sender, EventArgs e)
        {
            string ValorDoDeposito = txtValor.Text;

            if (String.IsNullOrEmpty(ValorDoDeposito))
            {
                MessageBox.Show("Informe um valor para deposito!");
            }
            else
            {
                double valorDeposito = Convert.ToDouble(ValorDoDeposito);
                Conta contaIndice = this.BuscaContaSelecionada();

                try
                {
                    contaIndice.Depositar(valorDeposito);
                    MessageBox.Show("Deposito efetuado com sucesso");
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Valor de deposito inválido!");
                }
                MostraConta();
            }
        }
        private void MostraConta()
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();

            txtTipoDaConta.Text = Convert.ToString(contaSelecionada);
            textoTitular.Text = contaSelecionada.Cliente;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoNumeroConta.Text = Convert.ToString(contaSelecionada.NumeroConta);
            txtValor.Clear();
            txtValor.Select();
        }
        private void btnSacar_Click(object sender, EventArgs e)
        {
            string ValorDoSaque = txtValor.Text;

            if (String.IsNullOrEmpty(ValorDoSaque))
            {
                MessageBox.Show("Informe um valor para Saque!");
            }
            else
            {
                double valorSacado = Convert.ToDouble(ValorDoSaque);
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
            FrmCadastroDeConta cadastro = new FrmCadastroDeConta(this);
            cadastro.ShowDialog();
        }

        private void btnExcluiCliente_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();
            comboContas.Items.Remove(contaSelecionada.Cliente);

            comboContas.Select();
            txtTipoDaConta.Clear();
            textoTitular.Clear();
            textoSaldo.Clear();
            textoNumeroConta.Clear();
        }
    }
}
