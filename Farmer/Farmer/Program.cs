/* Autores: José Miguel Guardado Quintanilla
            Brandon Rodrigo Henríquez Mejia

   Requerimientos: Elaborar un programa interactivo para farmacéutica 
                   esta desea contar con medicamentos para los diferentes 
                   tipos de enfermedades por cada enfermedad definida (mínimo 4) 
                   esta deberá tener un catálogo de medicamentos de diversa variedad 
                   ejemplo pastillas, inyecciones, jarabes y pomada para el que 
                   aplique a subes este medicamento mostrar el nombre, la cantidad 
                   de unidades si es pastilla, los miligramos si es jarabe o inyección 
                   y gramos si es pomada la fecha de vencimiento.

                             ● De estos datos poder hacer una venta.
                             ● Colocar datos de cliente.
              
                   Estos deberán presentar lo que serían sus atributos y métodos 
                   que se pueden realizar.
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Catálogo de medicamentos por enfermedad
            Dictionary<string, List<Medicamento>> catalogo = new Dictionary<string, List<Medicamento>>();
            catalogo.Add("Dolor de cabeza", new List<Medicamento>() {
            new Medicamento("Paracetamol", "pastillas", 20, new DateTime(2025, 6, 30)),
            new Medicamento("Ibuprofeno", "pastillas", 15, new DateTime(2024, 9, 15)),
            new Medicamento("Aspirina", "pastillas", 30, new DateTime(2026, 12, 31)),
            new Medicamento("Ibuprofeno en crema", "pomada", 100, new DateTime(2025, 5, 31)),
            });

            catalogo.Add("Dolor de estómago", new List<Medicamento>() {
            new Medicamento("Omeprazol", "pastillas", 25, new DateTime(2025, 6, 30)),
            new Medicamento("Ranitidina", "pastillas", 20, new DateTime(2024, 9, 15)),
            new Medicamento("Buscapina", "pastillas", 10, new DateTime(2023, 3, 1)),
            new Medicamento("Peptobismol", "jarabe", 150, new DateTime(2024, 11, 30)),
            });

            catalogo.Add("Resfriado", new List<Medicamento>() {
            new Medicamento("Ibuprofeno", "pastillas", 15, new DateTime(2024, 9, 15)),
            new Medicamento("Paracetamol", "pastillas", 20, new DateTime(2025, 6, 30)),
            new Medicamento("Loratadina", "pastillas", 30, new DateTime(2026, 12, 31)),
            new Medicamento("Vaporub", "pomada", 75, new DateTime(2025, 8, 31)),
            });

            catalogo.Add("Heridas", new List<Medicamento>() {
            new Medicamento("Gasas", "pastillas", 100, new DateTime(2026, 12, 31)),
            new Medicamento("Alcohol", "jarabe", 200, new DateTime(2024, 11, 30)),
            new Medicamento("Agua oxigenada", "jarabe", 100, new DateTime(2025, 5, 31)),
            new Medicamento("Curitas", "pomada", 75, new DateTime(2025, 8, 31)),
            });

            // Menú principal
            Console.WriteLine("------------------------");
            Console.WriteLine("Farmacia la Cura Segura");
            Console.WriteLine("------------------------");
            Console.WriteLine("Seleccione una enfermedad:\n");
            foreach (string enfermedad in catalogo.Keys)
            {
                Console.WriteLine("- " + enfermedad);
            }
            Console.WriteLine("----------------------------");
            string seleccionEnfermedad = Console.ReadLine();
            if (catalogo.ContainsKey(seleccionEnfermedad))
            {
                // Mostrar catálogo de medicamentos para la enfermedad seleccionada
                Console.WriteLine("\nMedicamentos para " + seleccionEnfermedad + ":");
                List<Medicamento> medicamentosEnfermedad = catalogo[seleccionEnfermedad];
                foreach (Medicamento medicamento in medicamentosEnfermedad)
                {
                    Console.WriteLine("- " + medicamento.nombre + " (" + medicamento.tipo + ")");
                }
            }
            else
            {
                Console.WriteLine("Enfermedad no encontrada");
            }
            Console.ReadLine();
        }
        class Medicamento
        {
            public string nombre;
            public string tipo; // pastillas, inyecciones, jarabes, pomadas
            public int cantidad; // unidades (pastillas), miligramos (jarabe/inyección), gramos (pomada)
            public DateTime fechaVencimiento;

            // Constructor para inicializar los atributos de un medicamento
            public Medicamento(string nombre, string tipo, int cantidad, DateTime fechaVencimiento)
            {
                this.nombre = nombre;
                this.tipo = tipo;
                this.cantidad = cantidad;
                this.fechaVencimiento = fechaVencimiento;
            }
        }

        class Venta
        {
            public List<Medicamento> medicamentos;
            public string nombreCliente;
            public string direccionCliente;

            // Constructor para inicializar los atributos de una venta
            public Venta(List<Medicamento> medicamentos, string nombreCliente, string direccionCliente)
            {
                this.medicamentos = medicamentos;
                this.nombreCliente = nombreCliente;
                this.direccionCliente = direccionCliente;
            }

            // Método para calcular el total de la venta
            public double calcularTotal()
            {
                double total = 0;
                foreach (Medicamento medicamento in medicamentos)
                {
                    total += 10 * medicamento.cantidad; // Precio fijo de 10 por unidad
                }
                return total;
            }
        }
    }
}
