using System;

/*
Consigna
Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

Mostrar el resultado en la consola.
 */

namespace Ejercicio_I07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            float resultado;
            float x;
            float y;

            Console.WriteLine("Ingrese cateto 1: ");
            ingreso = Console.ReadLine();

            while (float.TryParse(ingreso, out x) == false || float.Parse(ingreso) < 0)
            {
                Console.WriteLine("ERROR, Ingrese un numero valido: ");

                ingreso = Console.ReadLine();
            }

            Console.WriteLine("Ingrese cateto 2: ");
            ingreso = Console.ReadLine();

            while (float.TryParse(ingreso, out y) == false || float.Parse(ingreso) < 0)
            {
                Console.WriteLine("ERROR, Ingrese un numero valido: ");

                ingreso = Console.ReadLine();
            }

            resultado = TeeoremaDePitagoras.CalcularLongitud(x, y);

            Console.WriteLine("La hipotenusa es: {0}", resultado);
        }
    }
}
