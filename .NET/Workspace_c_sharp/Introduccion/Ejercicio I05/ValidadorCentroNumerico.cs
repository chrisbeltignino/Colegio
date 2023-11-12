using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I05
{
    internal class ValidadorCentroNumerico
    {
        public static bool EsCentroNumerico(int num)
        {
            int sumaIzquierda = 0;
            int sumaDerecha = 0;

            for (int i = 1; i < num; i++)
            {
                sumaIzquierda += i;

                for (int j = num; j > i; j--)
                {
                    sumaDerecha += j;
                }

                if (sumaIzquierda == sumaDerecha)
                {
                    return true;
                }
                else if (sumaIzquierda > sumaDerecha)
                {
                    break;
                }
                else
                {
                    sumaDerecha = 0;
                }
            }

            return false;
        }
    }
}
