﻿using Microsoft.VisualBasic;
using System;

/*

Consigna
Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.

 */

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            int valor;
            int max = 100;
            int min = -100;
            int auxMin = 0;
            int auxMax = 0;
            int acumulador = 0;
            float contador = 0;
            float promedio;

            do
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

                Console.Write("¿Desea continuar? (S/N)");
                respuesta = char.Parse(Console.ReadLine());

            } while (Validador.ValidarRespuesta(respuesta) == true);

            promedio = (float)(acumulador / contador);
            Console.WriteLine("Minimo: {0}, Maximo: {1}, Promedio: {2}", auxMin, auxMax, promedio);
            Console.ReadLine();
        }
    }
}
