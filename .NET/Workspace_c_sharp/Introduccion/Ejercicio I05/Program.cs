using System;

/*
  Consigna
Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
 */

namespace Ejercicio_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            string input = Console.ReadLine();

            int num;

            while (!int.TryParse(input, out num))
            {
                if (input.ToLower() == "salir")
                {
                    return;
                }

                Console.WriteLine("Error: debe ingresar un número o escribir 'salir' para terminar.");
                Console.Write("Ingrese un número: ");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Centros numéricos hasta {num}:");
            for (int i = 1; i <= num; i++)
            {
                if (ValidadorCentroNumerico.EsCentroNumerico(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
