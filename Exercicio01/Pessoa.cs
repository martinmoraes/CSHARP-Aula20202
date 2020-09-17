using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Pessoa
    {
        private String Nome { get; set; }
        private int Idade { get; set; }


        public Pessoa(string nome, int idade)
        {
            this.setNome(nome);
        }

        public String dados()
        {
            return this.Nome +" - "+ this.Idade;
        }


        public void setNome(string nome)
        {
            if(nome != "")
                this.Nome = nome;
        }
        public String getNome()
        {
            return this.Nome;
        }

        public String comparaIdade(Pessoa pessoa)
        {
            if (this.Idade == pessoa.Idade)
                return "Ambas tem a mesma idade";
            else if (this.Idade > pessoa.Idade)
                return this.Nome;
            else
                return pessoa.Nome;
        }

    }
}
