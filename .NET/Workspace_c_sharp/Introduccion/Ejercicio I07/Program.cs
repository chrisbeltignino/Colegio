using System;

/*
 *Consigna
Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años)
y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
 */

namespace Ejercicio_I07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int antiguedadAnios;
            string nombre = "";
            int cantidadHoras;
            float valorHoras;
            string respuesta;
            float importeBruto;
            float importeNeto;
            float descuentos;

            do
            {
                Console.WriteLine("Ingrese valor por hora: ");

                respuesta = Console.ReadLine();

                while (float.TryParse(respuesta, out valorHoras) == false)
                {
                    Console.WriteLine("ERROR, Ingrese un valor válido: ");

                    respuesta = Console.ReadLine();
                }

                Console.WriteLine("Ingrese el nombre del empleado: ");

                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la antiguedad (AÑOS): ");

                respuesta = Console.ReadLine();

                while (int.TryParse(respuesta, out antiguedadAnios) == false)
                {
                    Console.WriteLine("ERROR, Ingrese una cantidad válida de años de antiguedad: ");

                    respuesta = Console.ReadLine();
                }

                Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");

                respuesta = Console.ReadLine();

                while (int.TryParse(respuesta, out cantidadHoras) == false)
                {
                    Console.WriteLine("ERROR, Ingrese una cantidad válida de horas trabajadas: ");

                    respuesta = Console.ReadLine();
                }

                importeBruto = cantidadHoras * valorHoras;

                importeBruto = importeBruto + (antiguedadAnios * 150);

                descuentos = importeBruto * 13 / 100;

                importeNeto = importeBruto - descuentos;

                Console.WriteLine("---------------RECIBO DE SUELDO----------------");
                Console.WriteLine("|NOMBRE: {0}", nombre);
                Console.WriteLine("--------------------VALORES--------------------");
                Console.WriteLine("|ANTIGUEDAD: {0} AÑOS", antiguedadAnios);
                Console.WriteLine("|VALOR POR HORA: ${0}", valorHoras);
                Console.WriteLine("|TOTAL EN BRUTO: ${0}", importeBruto);
                Console.WriteLine("|TOTAL NETO: ${0}", importeNeto);
                Console.WriteLine("-----------------------------------------------");

                Console.WriteLine("\nDesea volver a iterar señor usuario? 'si' para seguir");

                respuesta = Console.ReadLine();


            } while (respuesta == "si");
        }

      /*class Empleado {
            private string nombre;
            private double valorHora;
            private int antiguedad;
            private int horasTrabajadas;
    
            public Empleado(string nombre, double valorHora, int antiguedad, int horasTrabajadas) {
                this.nombre = nombre;
                this.valorHora = valorHora;
                this.antiguedad = antiguedad;
                this.horasTrabajadas = horasTrabajadas;
            }
    
            public double calcularSalario() {
                double salarioBruto = this.valorHora * this.horasTrabajadas + this.antiguedad * 150;
                double salarioNeto = salarioBruto * 0.87;
                return salarioNeto;
            }
    
            public void mostrarRecibo() {
                Console.WriteLine("Nombre: " + this.nombre);
                Console.WriteLine("Antigüedad: " + this.antiguedad);
                Console.WriteLine("Valor hora: $" + this.valorHora);
                Console.WriteLine("Total a cobrar bruto: $" + (this.valorHora * this.horasTrabajadas + this.antiguedad * 150));
                Console.WriteLine("Total a cobrar neto: $" + calcularSalario());
                Console.WriteLine("---------------------------");
            }
        }

        class Program {
            static void Main(string[] args) {
                Console.Write("Ingrese la cantidad de empleados: ");
                int cantidadEmpleados = int.Parse(Console.ReadLine());
        
                Empleado[] empleados = new Empleado[cantidadEmpleados];
        
                for (int i = 0; i < cantidadEmpleados; i++) {
                    Console.WriteLine("Empleado #" + (i+1));
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Valor hora: ");
                    double valorHora = double.Parse(Console.ReadLine());
                    Console.Write("Antigüedad (en años): ");
                    int antiguedad = int.Parse(Console.ReadLine());
                    Console.Write("Horas trabajadas en el mes: ");
                    int horasTrabajadas = int.Parse(Console.ReadLine());
            
                    empleados[i] = new Empleado(nombre, valorHora, antiguedad, horasTrabajadas);
                    Console.WriteLine("---------------------------");
                }
        
                Console.WriteLine("RECIBOS DE PAGO");
                Console.WriteLine("---------------------------");
                foreach (Empleado empleado in empleados) {
                    empleado.mostrarRecibo();
                }
        
                Console.WriteLine("Presione cualquier tecla para salir.");
                Console.ReadKey();
            }
        }*/
    }
}
