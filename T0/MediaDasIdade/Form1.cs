using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaDasIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdadeCaleby  = 21;
            int IdadeVanessa = 25;
            int IdadeNicolas = 18;
            double MediaIdades = (IdadeCaleby + IdadeNicolas + IdadeVanessa)/3;

            MessageBox.Show("A media de idades é: " + MediaIdades)
        }
    }
}
