using CadastroPessoas.communs;
using CadastroPessoas.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoas
{
    public partial class Form1 : Form
    {
        private List<Pessoa> listaPessoas = new List<Pessoa>();
        private String arquivoTXT = @"C:\Users\Usuário\Downloads\teste\pessoas.txt ";
        private String arquivoJSON = @"C:\Users\Usuário\Downloads\teste\pessoas.json ";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            Pessoa umaPessoa = getPessoa();
            listaPessoas.Add(umaPessoa);
            limpaTextBox();
        }


        private Pessoa getPessoa()
        {
            Pessoa umaPessoa = new Pessoa();
            umaPessoa.Nome = textBoxNome.Text;
            umaPessoa.EMail = textBoxEMail.Text;
            try
            {
                umaPessoa.Idade = Numericos.leInt(textBoxIdade.Text);
                umaPessoa.Peso = Numericos.leFloat(textBoxPeso.Text);
            }catch(Exception e)
            {
                MessageBox.Show("Valores  inválidos");
            }

            return umaPessoa;
        }

        private void limpaTextBox()
        {
            textBoxEMail.Clear();
            textBoxNome.Clear();
            textBoxIdade.Clear();
            textBoxPeso.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Files.salvaPessoaCSV(arquivoTXT, listaPessoas);
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            List<String> listaStringPessoas =  Files.lerArquivoPessoas(arquivoTXT);

            listaStringPessoas.ForEach(pessoaString =>
            {
                richTextBoxPessoas.AppendText(pessoaString);
            });
        }

        private void buttonSalvaJson_Click(object sender, EventArgs e)
        {
            Files.salvaPessoaJSON(arquivoJSON, listaPessoas);
        }

        private void buttonAbrirJson_Click(object sender, EventArgs e)
        {
            listaPessoas = Files.lerArquivoPessoasJSON(arquivoJSON);

            listaPessoas.ForEach(pessoa =>
            {
                richTextBoxPessoas.AppendText(pessoa.ToString());
            });
        }
    }
}
