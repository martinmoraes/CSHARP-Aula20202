using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CadastroPessoas.entity;
using Newtonsoft.Json;

namespace CadastroPessoas.communs
{
    class Files
    {


        static public void salvaPessoaCSV(String arquivo, List<Pessoa> listaPessoa) {
            StreamWriter file = new StreamWriter(arquivo);
            listaPessoa.ForEach(pessoa =>
            {
                file.WriteLine(pessoa.ToString());
            });
            file.Close();
        }

        static public List<String> lerArquivoPessoas(String arquivo)
        {
            string line;
            List<String> listaPessoas = new List<string>();

            StreamReader file = new StreamReader(arquivo);
            while ((line = file.ReadLine()) != null)
            {
                listaPessoas.Add(line);
            }

            file.Close();
            return listaPessoas;
        }





        static public void salvaPessoaJSON(String arquivo, List<Pessoa> listaPessoa)
        {
            StreamWriter file = new StreamWriter(arquivo);
            listaPessoa.ForEach(pessoa =>
            {
                string output = JsonConvert.SerializeObject(pessoa);
                file.WriteLine(output);
            });
            file.Close();
        }

        static public List<Pessoa> lerArquivoPessoasJSON(String arquivo)
        {
            string line;
            List<Pessoa> listaPessoas = new List<Pessoa>();

            StreamReader file = new StreamReader(arquivo);
            while ((line = file.ReadLine()) != null)
            {
                Pessoa umaPessoal = JsonConvert.DeserializeObject<Pessoa>(line);
                listaPessoas.Add(umaPessoal);
            }

            file.Close();
            return listaPessoas;
        }


    }
}
