//Autores: José Miguel Guardado Quintanilla
//         Brandon Rodrigo Henríquez Mejía
/* 
  Requerimientos: Desarrollar en C# un programa interactivo para un grupo de tienda de calzados, 
  este tendrá que permitir al usuario elegir la tienda donde desea comprar.

  El programa mostrará un catálogo de estilo de zapatos, la marca de zapato, la talla y si tiene 
  algún descuento tanto para hombre como para mujer. 
  Estos deberán presentar lo que sería sus atributos y métodos que se pueden realizar.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapatosAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creando Objetos de Zapatos
            Shoe z1 = new Shoe("Deportivo", "Nike", "Hombre", 10, 100.00, 10.0);
            Shoe z2 = new Shoe("Bota", "Timberland", "Mujer", 8, 150.00, 0.0);
            Shoe z3 = new Shoe("Zapato de Vestir", "Cole Haan", "Hombre", 9, 200.00, 25.0);
            Shoe z4 = new Shoe("Sandalias", "Teva", "Mujer", 7, 50.00, 20.0);

            // Creando Tiendas
            Store store1 = new Store("Piecito Felíz", new List<Shoe> { z1, z2 });
            Store store2 = new Store("Comoditos", new List<Shoe> { z3, z4 });

            // Selección de Usuario
            Console.WriteLine("¡Bienvenido a la Tienda de Zapatos!");
            Console.WriteLine("Selecciona una tienda:");
            Console.WriteLine("1. {0}", store1.name);
            Console.WriteLine("2. {0}", store2.name);
            int choice = Convert.ToInt32(Console.ReadLine());

            // Mostrando Inventario de la Tienda Seleccionada
            if (choice == 1)
            {
                store1.displayInventory();
            }
            else if (choice == 2)
            {
                store2.displayInventory();
            }
            else
            {
                Console.WriteLine("Selección Inválida");
            }

            Console.ReadKey();
        
        }

        class Shoe
        {
            public string style;
            public string brand;
            public string gender;
            public int size;
            public double price;
            public double discount;

            public Shoe(string style, string brand, string gender, int size, double price, double discount)
            {
                this.style = style;
                this.brand = brand;
                this.gender = gender;
                this.size = size;
                this.price = price;
                this.discount = discount;
            }

            public void display()
            {
                Console.WriteLine("{0} {1} ({2}) - Size {3} - ${4:0.00} ({5}% off)",
                                  brand, style, gender, size, price, discount);
            }
        }

        class Store
        {
            public string name;
            public List<Shoe> inventory;

            public Store(string name, List<Shoe> inventory)
            {
                this.name = name;
                this.inventory = inventory;
            }

            public void displayInventory()
            {
                Console.WriteLine("Inventario para {0}:", name);
                Console.WriteLine("-----------------------");
                foreach (Shoe shoe in inventory)
                {
                    shoe.display();
                }
                Console.WriteLine();
            }
        }

    }
}
