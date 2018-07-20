using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosFatorias
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Fatorial = 1;
            for (int num = 1; num <= 10; num++)
            {
                Fatorial *= num;
                MessageBox.Show("o fatorial de " + num + " é " + Fatorial);
            }
        }
    }
}
