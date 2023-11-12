using System;

namespace ClassSumador
{
    public class Sumador
    {
        public int cantidadSumas;

        public Sumador() : this(0) { }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas += 1;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas += 1;
            return string.Format($"{a}{b}");
        }

        public static explicit operator int(Sumador s) 
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return (int)s1 + (int)s2;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return ((int)s1 == (int)s2);
        }

        public int Cantidad()
        {
            return this.cantidadSumas;
        }
    }
}
