using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaDidacticaejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa que administre un inventario de productos.
            Cada producto tiene un nombre, un precio y una cantidad en
            stock. El programa debe permitir:
            ✓ Añadir nuevos productos al inventario.
            ✓ Actualizar la cantidad en stock de un producto
            existente.
            ✓ Calcular el valor total del inventario (sumando el valor
            de cada producto: precio × cantidad en stock).*/

        Funciones funciones = new Funciones();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Añadir producto");
                Console.WriteLine("2. Actualizar stock");
                Console.WriteLine("3. Calcular valor total del inventario");
                Console.WriteLine("4. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        funciones.AgregarProducto();
                        break;
                    case "2":
                        funciones.ActualizarStock();
                        break;
                    case "3":
                        funciones.CalcularValorTotal();
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
