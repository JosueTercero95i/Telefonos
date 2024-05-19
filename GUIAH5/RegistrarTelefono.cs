using System;
using System.Collections.Generic;

namespace GUIAH5
{
    // Clase para registrar un teléfono en el inventario
    public class RegistrarTelefono
    {
        public void Registrar(List<Telefono> Inventario)
        {
            Telefono telefono = new Telefono();

           
            Console.WriteLine("Seleccione La Marca:");
            Console.WriteLine("1. Samsung");
            Console.WriteLine("2. Apple");
            Console.WriteLine("3. Xiaomi");
            Console.WriteLine("4. Huawei");
            Console.WriteLine("5. OnePlus");

            string opcionMarca;
            do
            {
                opcionMarca = Console.ReadLine();
                switch (opcionMarca)
                {
                    case "1":
                        telefono.Marca = "Samsung";
                        break;
                    case "2":
                        telefono.Marca = "Apple";
                        break;
                    case "3":
                        telefono.Marca = "Xiaomi";
                        break;
                    case "4":
                        telefono.Marca = "Huawei";
                        break;
                    case "5":
                        telefono.Marca = "OnePlus";
                        break;
                    default:
                        // Mostrar mensaje de error si la opción de marca es inválida
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (telefono.Marca == null); 

            Console.Write("Ingrese el modelo: ");
            telefono.Modelo = Console.ReadLine();

            Console.Write("Ingrese el precio: ");
            telefono.Precio = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese el stock: ");
            telefono.Stock = int.Parse(Console.ReadLine());

            Inventario.Add(telefono);

            Console.WriteLine("Teléfono registrado exitosamente.");
        }
    }
}
