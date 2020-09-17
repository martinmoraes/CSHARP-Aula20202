using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2E3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantidadeDois = 2 * int.Parse(tb2.Text);
            int quantidadeCinco = 5 * int.Parse(tb5.Text);
            int quantidadeDez = 10 * int.Parse(tb10.Text);
            int quantidadeVinte = 20 * int.Parse(tb20.Text);
            int quantidadeCinquenta = 50 * int.Parse(tb50.Text);
            int quantidadeCem= 100 * int.Parse(tb100.Text);

            int total = quantidadeDois + quantidadeCinco + quantidadeDez +
                quantidadeVinte + quantidadeCinquenta + quantidadeCem; 

            labelFechamento.Text = total.ToString();


        }
    }
}
