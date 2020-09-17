using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulo
{
    static class CalculaArea
    {

        static public double calcula(Triangulo triangulo)
        {
            float p = (triangulo.LadoA + triangulo.LadoB + triangulo.LadoC) / 2;
            double area = Math.Sqrt(p * (p - triangulo.LadoA) * (p - triangulo.LadoB) * (p - triangulo.LadoC));
            return area;
        }


        static public String maiorArea (Triangulo X, Triangulo Y)
        {
            double areaX= X.calculaArea();
            double areaY= Y.calculaArea();

            return areaX> areaY?
                X.Nome + ": " + areaX:
                Y.Nome + ": " + areaY;
        }
    }
}
