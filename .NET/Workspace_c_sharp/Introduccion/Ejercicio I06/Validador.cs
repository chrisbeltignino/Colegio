using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I06
{
    internal class Validador
    {
        public static bool Validar(string numero)
        {
            int n;
            return int.TryParse(numero, out n);
        }
    }
}
