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
    public partial class FrmCadastroDeConta : Form
    {
        private Conta[] EscolhaDaConta;
        private Form1 aplicacaoPrincipal;
        public FrmCadastroDeConta(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conta conta = selecionaConta();
            conta.NumeroConta = Convert.ToInt32(txtNumero.Text);
            conta.Cliente = txttitularConta.Text;
            this.aplicacaoPrincipal.AdicionaConta(conta);
            AtualizaTela();
        }
        private void AtualizaTela()
        {
            txttitularConta.Clear();
            txtNumero.Clear();
            txttitularConta.Select();
        }
        private Conta selecionaConta()
        {
            int I = EscolhaDeTipoDeConta.SelectedIndex;
            return EscolhaDaConta[I];
        }
        private void EscolhaDeTipoDeConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conta contaSelecionada = selecionaConta();
        }

        private void FrmCadastroDeConta_Load(object sender, EventArgs e)
        {
            this.EscolhaDaConta = new Conta[2];
            this.EscolhaDaConta[0] = new ContaCorrente();
            this.EscolhaDaConta[1] = new ContaPoupanca();
            EscolhaDeTipoDeConta.Items.Add(this.EscolhaDaConta[0]);
            EscolhaDeTipoDeConta.Items.Add(this.EscolhaDaConta[1]);
        }
    }
}