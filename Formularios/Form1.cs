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
    public partial class Form1 : Form
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        
        
        public Form1()
        {
            InitializeComponent();

            pessoas.Add(new Pessoa("a","a@a","111"));
            pessoas.Add(new Pessoa("b","a@a","222"));
            pessoas.Add(new Pessoa("c","a@a","333"));
            pessoas.Add(new Pessoa("d","a@a","444"));
            pessoas.Add(new Pessoa("e","a@a","555"));
            pessoas.Add(new Pessoa("f","a@a","666"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this, pessoas);
            form.Show();
        }

        public void pegaValor(string valor)
        {
            label1.Text = valor;
        }

    }
}
