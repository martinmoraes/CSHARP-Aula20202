using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.communs
{
    class Numericos
    {

        static public Int32 leInt(String valor)
        {
            try
            {
                return Convert.ToInt32(valor);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        static public float leFloat(String valor)
        {
            try
            {
                return float.Parse(valor);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
