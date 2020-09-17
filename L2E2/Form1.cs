using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2E2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorReais = double.Parse(tboxReais.Text);

            labelDolar.Text = (valorReais / 5.23).ToString();
            labelEuro.Text = (valorReais / 2.30).ToString();
            labelFranco.Text = (valorReais / 10.05).ToString();
            labelLibras.Text = (valorReais / 7.15).ToString();
        }
    }
}
