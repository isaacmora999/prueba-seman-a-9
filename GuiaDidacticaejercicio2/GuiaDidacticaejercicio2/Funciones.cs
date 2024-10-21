using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaDidacticaejercicio2
{
    internal class Funciones
    {
        public List<string> nombres = new List<string>();
        public List<decimal> precios = new List<decimal>();
        public List<int> cantidades = new List<int>();

        public void AgregarProducto()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad en stock: ");
            int cantidad = int.Parse(Console.ReadLine());

            nombres.Add(nombre);
            precios.Add(precio);
            cantidades.Add(cantidad);
            Console.WriteLine("Producto añadido con éxito.");
        }

        public void ActualizarStock()
        {
            Console.Write("Ingrese el nombre del producto a actualizar: ");
            string nombre = Console.ReadLine();

            int indice = nombres.IndexOf(nombre);
            if (indice != -1)
            {
                Console.Write("Ingrese la nueva cantidad en stock: ");
                int nuevaCantidad = int.Parse(Console.ReadLine());
                cantidades[indice] = nuevaCantidad;
                Console.WriteLine("Stock actualizado con éxito.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public void CalcularValorTotal()
        {
            decimal valorTotal = 0;
            for (int i = 0; i < nombres.Count; i++)
            {
                valorTotal += precios[i] * cantidades[i];
            }
            Console.WriteLine($"El valor total del inventario es: {valorTotal:C}");
        }
    }
}
