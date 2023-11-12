using System;

/*

Consigna
Escribir un programa que imprima por consola un triángulo como el siguiente:

*
***
*****
*******
*********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.

 */

namespace Ejercicio_I08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int alturaIngresada;
            int asteriscos = 0;

            Console.WriteLine("Ingrese la altura del triángulo: ");

            respuesta = Console.ReadLine();

            while (int.TryParse(respuesta, out alturaIngresada) == false || int.Parse(respuesta) <= 0)
            {
                Console.WriteLine("ERROR, Ingrese una altura válida: ");

                respuesta = Console.ReadLine();
            }

            for (int i = 1; i <= alturaIngresada; i++)
            {
                asteriscos = (i * 2) - 1;

                for (int a = 0; a < asteriscos; a++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
