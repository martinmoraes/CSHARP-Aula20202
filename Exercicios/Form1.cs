using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal TotalPneus = int.Parse(LabelTotalPneus.Text) + nUPPneus.Value;
            decimal TotalVelas = int.Parse(LabelTotalVelas.Text) + nUPVelas.Value;
            decimal TotalCarburadores = int.Parse(LabelTotalCarburadores.Text) + nUPCaradores.Value;
            decimal TotalMacanetas = int.Parse(LabelTotalMacanetas.Text) + nUPMacanetas.Value;

            if(TotalPneus <= 100)
                LabelTotalPneus.Text = TotalPneus.ToString();

            if (TotalVelas <= 100)
                LabelTotalVelas.Text = TotalVelas.ToString();

            if (TotalCarburadores <= 100)
                LabelTotalCarburadores.Text = TotalCarburadores.ToString();

            if (TotalMacanetas <= 100)
                LabelTotalMacanetas.Text = TotalMacanetas.ToString();

            LabelTotalGeral.Text = (TotalPneus + TotalVelas + TotalCarburadores + TotalMacanetas).ToString();
        }

    }
}
