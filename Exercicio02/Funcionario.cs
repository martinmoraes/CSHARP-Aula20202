using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio02
{
    class Funcionario
    {

        public String Name;
        public float Salario;



        public String dados()
        {
            return this.Name + " - " + this.Salario;
        }



    }
}
