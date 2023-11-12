using System;
using System.Linq;

namespace IntroduccionLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] nombres = new string[5] { "Ana", "Juan", "Pepe", "Jero", "German" };

            //Buscar PARES
            var pares =
                from numero in numeros
                where (numero % 2) == 0
                select numero;

            //Buscar IMPARES
            var impares =
                from numero in numeros
                where (numero % 2) != 0
                select numero;

            //Buscar por RANGO
            var rango =
               from numero in numeros
               where (numero > 5 && numero <= 8)
               select numero;

            //Buscar por cantidad de caracteres en NOMBRE
            var nombreLenght = 
                from nombre in nombres
                where(nombre.Length > 3)
                select nombre;


            foreach (int numero in pares)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine();

            foreach (int numero in impares)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine();

            foreach (int numero in rango)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine();

            foreach (var nombre in nombreLenght)
            {
                Console.Write(nombre + " ");
            }

            /*
            DevolverConsulta(nombres);

            void DevolverConsulta(string[] nombres)
            {
                foreach (var nombre in nombres)
                {
                    Console.Write(nombre);
                }
            }
            */
        }
    }
}
