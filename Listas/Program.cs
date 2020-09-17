using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Laranja");
            list.Add("Maça");
            list.Add("Pêra");

            foreach(String fruta in list)
            {
                Console.WriteLine(fruta);
            }



            List<string> cidades = new List<string> { "Curitiba", "Quatro Barras", "Pinhais" };
            cidades.ForEach(cidade => Console.WriteLine(cidade));

        }
    }
}
