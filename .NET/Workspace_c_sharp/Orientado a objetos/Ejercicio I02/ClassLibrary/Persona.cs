using System;

namespace ClassLibrary
{
    public class Persona
    {
        public string nombre;
        public DateTime fechaDeNacimiento;
        public int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni) 
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string SetNombre(string nombre)
        {
            return this.nombre = nombre;
        }

        public DateTime GetDateTime()
        {
            return fechaDeNacimiento;
        }

        public DateTime SetDateTime(DateTime dt) 
        {
            return this.fechaDeNacimiento = dt;
        }

        public int GetDni() 
        { 
            return dni; 
        }

        public int SetDni(int dni) 
        { 
            return this.dni = dni; 
        }

        public int CalcularEdad()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - fechaDeNacimiento.Year;
            if(fechaDeNacimiento > now.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        public string Mostrar()
        {
            return "Nombre: " + nombre + "\nFecha de nacimiento: " + fechaDeNacimiento.ToString("dd/MM/yyyy") + "\nDNI: " + dni + "\nEdad: " + CalcularEdad().ToString();
        }

        public string EsMayorDeEdad()
        {
            return (CalcularEdad() >= 18) ? "Es mayor de edad" : "Es menor";
        }
    }
}
