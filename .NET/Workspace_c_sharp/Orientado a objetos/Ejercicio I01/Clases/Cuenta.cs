using System;

namespace Clases
{
    public class Cuenta
    {
        public string titular;
        public decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            return "Titular: " + titular + "\nCantidad: " + cantidad;
        }

        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
            }
        }

        public void Retirar(decimal monto)
        {
            cantidad -= monto;
        }
    }
}
