using System;
using System.Windows.Forms;

namespace Exercicio01.form
{
    public partial class Cliente : Form
    {
        public Cliente(String nome)
        {
            InitializeComponent();
            button1.Text = nome;
        }


       
    }
}
