using System;

/*
 Consigna
Escribir un programa que determine si un año es bisiesto.

Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
 */

namespace Ejercicio_I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFinal;
            int flagAnio = 1;
            string respuesta;
            Boolean esBis = false;

            do
            {
                Console.WriteLine("Ingrese un año de inicio:");

                respuesta = Console.ReadLine();

                while (int.TryParse(respuesta, out anioInicio) == false && respuesta != "SALIR")
                {
                    Console.WriteLine("ERROR, Ingrese un año de inicio:");

                    respuesta = Console.ReadLine();
                }

                Console.WriteLine("Ingrese un año de fin:");

                respuesta = Console.ReadLine();

                while (int.TryParse(respuesta, out anioFinal) == false && respuesta != "SALIR")
                {
                    Console.WriteLine("ERROR, Ingrese un año de fin:");

                    respuesta = Console.ReadLine();
                }

                if (respuesta != "SALIR")
                {
                    for (int i = anioInicio; i < anioFinal; i++)
                    {
                        esBis = false;

                        if ((i % 4) == 0)
                        {
                            esBis = true;
                        }

                        if (((i % 100) == 0) && ((i % 400) == 0))
                        {
                            esBis = true;
                        }

                        if (esBis)
                        {
                            if (flagAnio == 1)
                            {
                                flagAnio = 0;
                                Console.WriteLine("AÑOS BISIESTOS:");
                            }
                            Console.WriteLine("{0}", i);
                        }
                    }

                    if (flagAnio == 1)
                    {
                        Console.WriteLine("NO HAY AÑOS BISIESTOS ENTRE ESE RANGO.");
                    }

                    Console.WriteLine("Desea volver a iterar señor usuario? 'si' para seguir");

                    respuesta = Console.ReadLine();
                }

            } while (ValidadorRespuesta.ValidarRespuesta(respuesta));
        }
    }
}
