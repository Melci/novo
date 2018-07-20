using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Votação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  Idade      = 28;
            bool Brasileiro = true;

            if (Idade > 16 && Brasileiro == true)
            {
                MessageBox.Show("Você pode Votar!");
            }
            else
            {
                MessageBox.Show("Você não pode Votar!");
            }
        }
    }
}
