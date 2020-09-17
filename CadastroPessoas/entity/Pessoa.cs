using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.entity
{
    class Pessoa 
    {
        public String Nome { get; set; }
        public String EMail { get; set; }
        public int  Idade { get; set; }
        public float  Peso { get; set; }


        public override string ToString()
        {
            return "Nome: " + Nome + ", "+
                "E-Mail: " + EMail + ", " +
                "Idade: " + Idade + ", " +
                "Peso: " + Peso;
        }

    }
}
