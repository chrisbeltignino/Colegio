using System;

/*

Consigna
Desarrollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

public string ConvertirDecimalABinario(int numeroEntero) {}

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

public int ConvertirBinarioADecimal(int numeroEntero) {}

IMPORTANTE
NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.

 */

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int numeroIngresado;
            int binario;
            int decimall;

            Console.Write("Ingrese un numero: ");
            respuesta = Console.ReadLine();

            while (int.TryParse(respuesta, out numeroIngresado) == false)
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
                respuesta = Console.ReadLine();
            }

            binario = Conversor.ConvertirDecimalABinario(numeroIngresado);
            decimall = Conversor.ConvertirBinarioADecimal(binario);

            Console.WriteLine("Numero decimal ingresado: {0}, Numero binario: {1}, Numero de binario a decimal: {2}", numeroIngresado, binario, decimall);
            Console.ReadLine();
        }
    }
}
