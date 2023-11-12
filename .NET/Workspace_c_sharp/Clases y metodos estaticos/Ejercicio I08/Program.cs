using System;

/*
Consigna
Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
 */

namespace Ejercicio_I08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaIngresada = new DateTime();
            Console.Write("Ingrese su fecha de nacimiento(DD/MM/AAAA): ");
            fechaIngresada = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(CalcularAños.Edad(fechaIngresada));
        }
    }
}
