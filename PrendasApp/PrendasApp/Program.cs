// Autores: José Miguel Guardado Quintanilla
//          Brandon Rodrigo Henríquez Mejía

/* Elaborar un programa para mostrar un catálogo de prendas de vestir categoría según la
calidad de prendas, se deberá crear una clase abstracta para cada tipo de prenda, asi
como las característica o diseño y tallas disponibles para el cliente. Estos deberán
presentar lo que sería sus atributos y métodos que se pueden realizar.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrendasApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Catálogo de Prendas, acá te las mostramos: \n ");
            // Crear algunas prendas y agregarlas al catálogo
            Camiseta camiseta1 = new Camiseta();
            camiseta1.Nombre = "Camiseta básica";
            camiseta1.Categoria = "Camisetas";
            camiseta1.Calidad = "Regular";
            camiseta1.Material = "Algodón";
            camiseta1.Color = "Blanco";
            camiseta1.Tallas = new List<string> { "S", "M", "L", "XL" };

            Pantalones pantalones1 = new Pantalones();
            pantalones1.Nombre = "Pantalones de mezclilla";
            pantalones1.Categoria = "Pantalones";
            pantalones1.Calidad = "Premium";
            pantalones1.Material = "Mezclilla";
            pantalones1.Estilo = "Recto";
            pantalones1.Tallas = new List<string> { "28", "30", "32", "34", "36" };

            Chaqueta chaqueta1 = new Chaqueta();
            chaqueta1.Nombre = "Chaqueta de cuero";
            chaqueta1.Categoria = "Chaquetas";
            chaqueta1.Calidad = "Alta";
            chaqueta1.Material = "Cuero";
            chaqueta1.Color = "Negro";
            chaqueta1.Estilo = "Motociclista";
            chaqueta1.Tallas = new List<string> { "S", "M", "L", "XL", "XXL" };

            Catalogo catalogo = new Catalogo();
            catalogo.AgregarPrenda(camiseta1);
            catalogo.AgregarPrenda(pantalones1);
            catalogo.AgregarPrenda(chaqueta1);

            // Mostrar el catálogo
            catalogo.MostrarCatalogo();
            Console.ReadLine();
        }
        // Clase abstracta para representar una prenda de vestir
        abstract class Prenda
        {
            public string Nombre { get; set; }
            public string Categoria { get; set; }
            public string Calidad { get; set; }
            public List<string> Tallas { get; set; }

            // Método abstracto para mostrar la información de la prenda
            public abstract void MostrarInfo();
        }

        // Clase para representar una camiseta
        class Camiseta : Prenda
        {
            public string Material { get; set; }
            public string Color { get; set; }

            // Implementación del método abstracto de la clase base
            public override void MostrarInfo()
            {
                Console.WriteLine("Camiseta: {0}", Nombre);
                Console.WriteLine("Material: {0}", Material);
                Console.WriteLine("Color: {0}", Color);
                Console.WriteLine("Tallas disponibles: {0}", string.Join(", ", Tallas));
            }
        }

        // Clase para representar unos pantalones
        class Pantalones : Prenda
        {
            public string Material { get; set; }
            public string Estilo { get; set; }

            // Implementación del método abstracto de la clase base
            public override void MostrarInfo()
            {
                Console.WriteLine("Pantalones: {0}", Nombre);
                Console.WriteLine("Material: {0}", Material);
                Console.WriteLine("Estilo: {0}", Estilo);
                Console.WriteLine("Tallas disponibles: {0}", string.Join(", ", Tallas));
            }
        }

        // Clase para representar una chaqueta
        class Chaqueta : Prenda
        {
            public string Material { get; set; }
            public string Color { get; set; }
            public string Estilo { get; set; }

            // Implementación del método abstracto de la clase base
            public override void MostrarInfo()
            {
                Console.WriteLine("Chaqueta: {0}", Nombre);
                Console.WriteLine("Material: {0}", Material);
                Console.WriteLine("Color: {0}", Color);
                Console.WriteLine("Estilo: {0}", Estilo);
                Console.WriteLine("Tallas disponibles: {0}", string.Join(", ", Tallas));
            }
        }

        // Clase para representar un catálogo de prendas de vestir
        class Catalogo
        {
            private List<Prenda> prendas;

            public Catalogo()
            {
                prendas = new List<Prenda>();
            }

            // Agregar una prenda al catálogo
            public void AgregarPrenda(Prenda prenda)
            {
                prendas.Add(prenda);
            }

            // Mostrar todas las prendas del catálogo
            public void MostrarCatalogo()
            {
                foreach (Prenda prenda in prendas)
                {
                    prenda.MostrarInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
