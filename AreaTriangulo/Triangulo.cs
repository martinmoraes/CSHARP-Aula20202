using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTriangulo
{
    class Triangulo
    {
        public float LadoA { get; set; }
        public float LadoB { get; set; }
        public float LadoC { get; set; }
        public String Nome { get; set; }


        public Triangulo(String nome)
        {
            this.Nome = nome;
        }



        public double calculaArea()
        {
            float p = (LadoA + LadoB + LadoC) / 2;
            double area = Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
            return area;
        }

        public String maiorArea(Triangulo triangulo)
        {
            double areaLocal = this.calculaArea();
            double areaRemota = triangulo.calculaArea();

            return areaLocal > areaRemota ?
                this.Nome + ": " + areaLocal :
                triangulo.Nome + ": " + areaRemota;


        }


        static public String maiorArea(Triangulo X, Triangulo Y)
        {
            double areaX = X.calculaArea();
            double areaY = Y.calculaArea();

            return areaX > areaY ?
                X.Nome + ": " + areaX :
                Y.Nome + ": " + areaY;
        }


    }
}
