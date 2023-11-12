using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I06
{
    public class ValidadorRespuesta
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            Boolean esValido = false;

            if (respuesta == "s")
            {
                esValido = true;
            }

            return esValido;
        }
    }
}
