using System;
using ClassSumador;

namespace Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassSumador.Sumador sum = new ClassSumador.Sumador();
            ClassSumador.Sumador sum2 = new ClassSumador.Sumador(2);

            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum2.Sumar(100, 687)} Sumador {sum2.Cantidad()}");
            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum.Sumar("HOla ", "Munjjjjjdo")} Sumador {sum.Cantidad()}");
            if (sum | sum2)
            {
                Console.WriteLine("ES true");
            }
            Console.WriteLine($"suma de objetos {sum + sum2}");
        }
    }
}
