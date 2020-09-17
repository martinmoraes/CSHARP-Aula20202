using System;
using System.Collections.Generic;

namespace NovaLita
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> frutas = new List<string>();
            frutas.Add("Maça");
            frutas.Add("Pêra");
            frutas.Add("Laranja");
            frutas.Add("Limão");
            frutas.Add("Abacaxi");

            String[] nova = frutas.ToArray();


            frutas.Insert(2, "Banana");

            Console.WriteLine(frutas.Contains("Maça"));

            Console.WriteLine("Quantidade de frutas: " + frutas.Count);


            List<string> frutasL = frutas.FindAll(fruta => fruta[0] == 'L');
            frutasL.ForEach(fruta => Console.WriteLine("Uma Fruta: " + fruta));


            //Boolean result = frutas.Exists(fruta =>
            //{
            //    Boolean encontrou = false;
            //    if(fruta[0] == 'L')
            //    {
            //        Console.WriteLine("Fruta encontrada: " + fruta);
            //        encontrou = true;
            //    }
            //    return encontrou;
            //});

            //Console.WriteLine("resulto de Exists: " + result);

            //frutas.ForEach(fruta =>
            //{
            //    Console.WriteLine("Fruta: " + fruta);
            //});

            //foreach(string fruta in frutas)
            //{
            //    Console.WriteLine("Fruta: " + fruta);
            //}


            //List<string> cidades = new List<string>() { "Curitiba", "Pinhais", "Quatro Barras" };
            //cidades.ForEach(cidade => Console.WriteLine(cidade));
        }
    }
}
