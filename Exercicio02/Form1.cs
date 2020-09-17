using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio02
{
    public partial class Form1 : Form
    {
        private int QtdeCadastrado = 0;
        private Funcionario funcionario01;
        private Funcionario funcionario02;


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.QtdeCadastrado == 0)
            {
                this.funcionario01 = getValores();
                label3.Text = funcionario01.dados();
                QtdeCadastrado++;
            }else
            {
                this.funcionario02 = getValores();
                label4.Text = funcionario02.dados();
                label5.Text = ((funcionario01.Salario + funcionario02.Salario) / 2).ToString();
            }
        }

        private Funcionario getValores()
        {
            Funcionario umFuncionario = new Funcionario();

            umFuncionario.Name = textBoxNome.Text;
            umFuncionario.Salario = float.Parse(textBoxSalario.Text);

            textBoxNome.Text = "";
            textBoxSalario.Text = "";

            return umFuncionario;
        }
    }
}
