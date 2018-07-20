using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 3;
            int b = 7;
            int c = 2;

            double a1;
            double a2;
            double Delta;

            Delta = b * b - 4 * a * c;
               a1 = (-b + Math.Sqrt(Delta)) / (2 * a);
               a2 = (-b - Math.Sqrt(Delta)) / (2 * a);

            MessageBox.Show("Primeiro Resultado: " + a1);
            MessageBox.Show( "Segundo Resultado: " + a2);
        }
    }
}
