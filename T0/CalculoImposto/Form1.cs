using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoImposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculaImposto_Click(object sender, EventArgs e)
        {
            double ValorNotaFiscal = 1000;
            double Imposto;

            if (ValorNotaFiscal < 1000)
            {
                Imposto = (2 / 100);
            }
            else
            if (ValorNotaFiscal < 3000)
            {
                Imposto = (2.5 / 100);
            }
            else
            if (ValorNotaFiscal < 7000)
            {
                Imposto = (2.8 / 100);
            }
            else
            {
                Imposto = (3 / 100);
            }

            MessageBox.Show("O Valor do Imposto é: " + Imposto);
        }
    }
}
