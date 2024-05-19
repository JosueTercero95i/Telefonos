using System;
using System.Collections.Generic;

namespace GUIAH5
{
    public class Telefono
    {
        // Propiedades del teléfono
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        // Método para mostrar la información del teléfono
        public void MostrarInfo()
        {
            Console.WriteLine($"Marca {Marca} Modelo: {Modelo}, Precio: ${Precio}, Stock: {Stock}");
        }
    }

    public class Program
    {
        //inventario
        public static List<Telefono> Inventario = new List<Telefono>();

        // Método para mostrar el inventario de teléfonos
        public void MostrarInventario()
        {
            Console.WriteLine("Inventario de Teléfonos:");
            foreach (var telefono in Inventario)
            {
                telefono.MostrarInfo();
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program programa = new Program();

            // Bucle principal del programa
            while (true)
            {
                // Menú
                Console.WriteLine("=========Menu==========");
                Console.WriteLine("1. Registrar Teléfono");
                Console.WriteLine("2. Mostrar Inventario");
                Console.WriteLine("3. Salir");
                Console.WriteLine("=======================");
                Console.WriteLine("Seleccione una opción: ");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                    // Opcion 1: registrar telefonos
                        RegistrarTelefono registrador = new RegistrarTelefono();
                        registrador.Registrar(Inventario);
                        break;

                    // opcion 2: Mostrar el inventario de teléfonos
                    case "2":
                        programa.MostrarInventario();
                        break;

                    // opcion 3: Salir del programa
                    case "3":
                        return;

                    default:
                        Console.WriteLine("Opción no válida, intente nuevamente.");
                        break;
                }
            }
        }
    }
}
