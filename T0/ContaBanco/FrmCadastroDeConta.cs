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
        private Form1 aplicacaoPrincipal;
        public FrmCadastroDeConta(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.NumeroConta = Convert.ToInt32(txtNumero.Text);
            conta.Cliente = new Cliente(txttitularConta.Text);
            this.aplicacaoPrincipal.AdicionaConta(conta);
        }
    }
}