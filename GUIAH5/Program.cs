using System;
using System.Collections.Generic;

namespace GUIAH5
{
    public class Telefono
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"Marca {Marca} Modelo: {Modelo}, Precio: ${Precio}, Stock: {Stock}");
        }
    }

    public class Program
    {
        public static List<Telefono> Inventario = new List<Telefono>();

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

            while (true)
            {
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
                        RegistrarTelefono registrador = new RegistrarTelefono();
                        registrador.Registrar(Inventario);
                        break;

                    case "2":
                        programa.MostrarInventario();
                        break;

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
