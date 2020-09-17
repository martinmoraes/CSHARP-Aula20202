using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercicio01.form;

namespace Exercicio01
{
    public partial class Form1 : Form
    {

        Pessoa pessoa01;
        Pessoa pessoa02;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pessoa01 = new Pessoa();
            pessoa01.Nome = tbNome.Text;
            pessoa01.Idade = Convert.ToInt32(tbIdade.Text);

            tbIdade.Text = "";
            tbNome.Text = "";

            label3.Text = pessoa01.dados();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pessoa02 = new Pessoa();
            pessoa02.Nome = tbNome.Text;
            pessoa02.Idade = Convert.ToInt32(tbIdade.Text);

            tbIdade.Text = "";
            tbNome.Text = "";

            label4.Text = pessoa02.dados();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //label5.Text = pessoa01.comparaIdade(pessoa02);


            if (pessoa01.Idade == pessoa02.Idade)
                label5.Text = "Ambas tem a mesma idade";
            else if (pessoa01.Idade > pessoa02.Idade)
                label5.Text = "A " + pessoa01.Nome + " é de mais idade";
            else
                label5.Text = "A " + pessoa02.Nome + " é de mais idade";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new form.Cliente("Olá Martin");
            f.Show();
        }
    }
}
