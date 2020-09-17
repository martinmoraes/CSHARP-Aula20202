using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Form2 : Form
    {
        private Form1 form { get; }
        private List<Pessoa> Pessoas { get; }

        public Form2(Form1 form, List<Pessoa> pessoas)
        {
            InitializeComponent();

            this.form = form;
            this.Pessoas = pessoas;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            form.pegaValor(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoas.ForEach(pessoa =>
            {
                string[] linha = new string[] { pessoa.Nome, pessoa.EMail, pessoa.Fone };
                dataGridView1.Rows.Add(linha);
            });
        }
    }
}
