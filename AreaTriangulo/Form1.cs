using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTriangulo
{
    public partial class Form1 : Form
    {
        private Triangulo X;
        private Triangulo Y;



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            X = new Triangulo("X");
            X.LadoA = float.Parse(textBoxLadoA.Text);
            X.LadoB = float.Parse(textBoxLadoB.Text);
            X.LadoC = float.Parse(textBoxLadoC.Text);
            limparCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Y = new Triangulo("Y");
            Y.LadoA = float.Parse(textBoxLadoA.Text);
            Y.LadoB = float.Parse(textBoxLadoB.Text);
            Y.LadoC = float.Parse(textBoxLadoC.Text);
            limparCampos();
        }


        private void limparCampos()
        {
            textBoxLadoA.Clear();
            textBoxLadoB.Clear();
            textBoxLadoC.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //labelResultado.Text += "X: "+ X.calculaArea() +" Y: "+ Y.calculaArea();

            labelResultado.Text += "X: " + CalculaArea.calcula(X) + " Y: " + CalculaArea.calcula(Y);

            //labelMaiorArea.Text = X.maiorArea(Y);
            //labelMaiorArea.Text = CalculaArea.maiorArea(X, Y);
            labelMaiorArea.Text = Triangulo.maiorArea(X, Y);
        }

        /*
         * Constructor
         * Static
         * Classe calculadora
         * 
         */
    }
}
