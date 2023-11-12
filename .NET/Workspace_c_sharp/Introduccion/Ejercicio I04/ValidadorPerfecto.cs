using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04
{
    public class ValidadorPerfecto
    {
        public static bool EsNumeroPerfecto(int num)
        {
            int suma = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    suma += i;
                }
            }

            return suma == num;
        }
    }
}
