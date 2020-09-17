using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string EMail{ get; set; }
        public string Fone{ get; set; }

        public Pessoa(string Nome, string EMail, string Fone)
        {
            this.Nome = Nome;
            this.EMail = EMail;
            this.Fone = Fone;
        }
    }
}
