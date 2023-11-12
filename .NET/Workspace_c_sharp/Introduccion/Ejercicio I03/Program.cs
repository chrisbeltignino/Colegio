using System;

/*
 Consigna
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
 */

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool operar = true;

            while (operar)
            {
                Console.Write("Ingrese un número o escriba 'salir' para terminar: ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "salir")
                {
                    return;
                }

                if (!int.TryParse(entrada, out int num))
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero o escriba 'salir' para terminar.");
                    continue;
                }

                Console.WriteLine($"Los números primos hasta {num} son:");

                for (int i = 2; i <= num; i++)
                {
                    if (ValidadorPrimo.EsPrimo(i))
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.Write("¿Desea volver a operar? (S/N): ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() != "s")
                {
                    operar = false;
                }
            }
        }
    }
}
