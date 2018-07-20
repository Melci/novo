using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imprimindo_a_soma_dos_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SomaNumeros = 0;
            for (int i = 1; i <= 1000; i += 1)
            {
                SomaNumeros += 1;
            }
            MessageBox.Show("O Valor da soma é: " + SomaNumeros);
        }
    }
}
