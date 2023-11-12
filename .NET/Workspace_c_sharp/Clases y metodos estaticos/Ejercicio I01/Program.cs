using System;

/*

Consigna
Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

IMPORTANTE
Utilizar variables escalares, NO utilizar vectores/arrays.

 */

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int max = 100;
            int min = -100;
            int auxMin = 0;
            int auxMax = 0;
            int acumulador = 0;
            float contador = 0;
            float promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                valor = int.Parse(Console.ReadLine());

                while (Validador.Validar(valor, min, max) == false)
                {
                    Console.Write("ERROR. ¡Reingresar número!: ");
                    valor = int.Parse(Console.ReadLine());
                }

                acumulador += valor;
                contador++;

                if (valor > auxMax)
                {
                    auxMax = valor;
                }
                if (valor < auxMin)
                {
                    auxMin = valor;
                }
            }

            promedio = (float)(acumulador / contador);
            Console.WriteLine("Minimo: {0}, Maximo: {1}, Promedio: {2}", auxMin, auxMax, promedio);
            Console.ReadLine();
        }
    }
}
