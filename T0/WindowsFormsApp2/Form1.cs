using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void btnCalcularSomas_Click(object sender, EventArgs e)
        {
            int Resultado, Soma, N2 = 0;
            int N1        = 1;
            string Mensagem = "Os numeros da Serie de Fibonacci são: ";

            for (int i = 1; i <= 10; i++)
            {
                Soma      = N1 + N2;
                Resultado = Soma;
                N1        = N2;

                MessageBox.Show(Mensagem
                              + Resultado);

                N2 = Resultado;
            }
        }
    }
}
