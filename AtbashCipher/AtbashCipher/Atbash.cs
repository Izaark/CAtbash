using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtbashCipher
{
    class Atbash
    {
        public String res;
        public String MAtbash(String cadena)
        {
            foreach (char c in cadena.ToCharArray()) //METODO PARA TRANSFORMAR STRING EN ARREGLO DE CAR
            {
                res += (char)(-1 * c + 155);               //ENCAPSULAMIRNTO               
            }
            return res;
        }
    }
}
