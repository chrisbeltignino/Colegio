using System;

/**
Consigna
Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

Escribir una aplicación que encuentre los 4 primeros números perfectos.
 **/

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int numero = 1;

            while (contador < 5)
            {
                if (ValidadorPerfecto.EsNumeroPerfecto(numero))
                {
                    Console.WriteLine("El numero {0} es perfecto {1}", contador, numero);
                    contador++;
                }

                numero++;
            }
            Console.ReadLine();
        }
    }
}
