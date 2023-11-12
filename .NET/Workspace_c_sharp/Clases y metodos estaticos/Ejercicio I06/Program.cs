using System;

/*
Consigna
Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

public double CalcularAreaCuadrado(double longitudLado) {}

public double CalcularAreaTriangulo(double base, double altura) {}

public double CalcularAreaCirculo(double radio) {}

El ingreso de los datos como la visualización se deberán realizar desde el método Main().
 */

namespace Ejercicio_I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area de un cuadrado de lado 5: " + CalculadoraDeArea.CalcularAreaCuadrado(5));

            Console.WriteLine("Area de un triangulo de base 2 y altura 3: " + CalculadoraDeArea.CalcularAreaTriangulo(2, 3));

            Console.WriteLine("Area de un circulo de radio 3: " + CalculadoraDeArea.CalcularAreaCirculo(3));
        }
    }
}
