using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2_SEMANA9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Implementa un programa que use un arreglo estático para almacenar las ventas diarias
            de un negocio. Crea funciones para ingresar las ventas, calcular el total vendido y
            encontrar el día con la venta más alta.
            - Utilizar funciones con parámetros.
            - Implementar ciclos.*/

            double[] ventas = new double [7];
            double ventasTotales = 0;

            Console.WriteLine("Es un programa que almacena las ventas diarias, calcula el total vendido y encuentra el dia con la venta mas alta");
             Console.WriteLine("Ingresa las ventas por dia de la semana");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Venta del dia {i+1}: ");
                 ventas[i] = double.Parse(Console.ReadLine());
            }

            ventasTotales = CalcularVentas.totalVendido(ventas);
            CalcularVentas.imprimirtotalVendido (ventasTotales);

            int diaMayorVenta = CalcularVentas.EncontrarDiaConMayorVenta(ventas);
            Console.WriteLine("Día con Mayor Venta: " + diaMayorVenta);

            Console.ReadKey();
        }
    }
}
