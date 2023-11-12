using System;
using System.Text;

namespace ClasesEjemploUniversal
{
    public class Estudiante
    {
        public string nombre;
        public string apellido;
        public string legajo;
        public int notaPrimerParcial;
        public int notaSegundoParcial;
        public static Random random = new Random();

        public Estudiante() { }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota; 
        }

        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2f;
        }

        private double CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }else{
                return  -1;
            }
        }

        public string Mostrar()
        {
            double notaFinal;

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n", nombre);
            sb.AppendFormat("Apellido: {0}\n", apellido);
            sb.AppendFormat("Legajo: {0}\n", legajo);
            sb.AppendFormat("Nota primer parcial: {0}\n", notaPrimerParcial);
            sb.AppendFormat("Nota segundo parcial: {0}\n", notaSegundoParcial);
            sb.AppendFormat("Promedio: {0}\n", CalcularPromedio());
            notaFinal = CalcularNotaFinal();

            if (notaFinal != -1)
            {
                sb.AppendFormat("Nota final: {0}\n", notaFinal);
            }else{
                sb.Append("Alumno desaprobado\n");
            }
            return sb.ToString();
        }
    }
}
