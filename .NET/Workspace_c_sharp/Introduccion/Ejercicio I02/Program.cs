using System;
using System.ComponentModel.DataAnnotations;

/*
 Consigna
Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
 */

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingresar un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (Validador.Validar(numero))
            {
                Console.Write("ERROR. Ingresar un número CORRECTO: ");
                numero = int.Parse(Console.ReadLine());
            }

            double elevadoAlCubo = Math.Pow(numero, 3); // Elevarlo a la potencia 3
            double elevadoAlCuadrado = Math.Pow(numero, 2); // Elevarlo a la potencia 2

            Console.WriteLine("{0} elevado al cubo es {1} \n{0} elevado al cuadrado es {2}", numero, elevadoAlCubo, elevadoAlCuadrado);
            Console.ReadLine();
        }
    }
}
