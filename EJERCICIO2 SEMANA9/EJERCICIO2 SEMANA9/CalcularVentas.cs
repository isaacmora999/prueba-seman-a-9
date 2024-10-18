using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2_SEMANA9
{
    internal class CalcularVentas
    {
        /*Crea funciones para ingresar las ventas, calcular el total vendido y
            encontrar el día con la venta más alta.
            - Utilizar funciones con parámetros.
            - Implementar ciclos.*/

       public static double totalVendido(double[] ventas)
        {
            double suma = 0;

            foreach (double venta in ventas)
            {
                suma += venta;
            }

            return suma;
        }
        
        public static void imprimirtotalVendido(double ventasTotales)
        {
            Console.WriteLine($"El total de ventas es {ventasTotales}");
        }

        public static int EncontrarDiaConMayorVenta(double[] ventas)
        {
            int diaMayorVenta = 1;
            double mayorVenta = ventas[0];
            for (int i = 1; i < ventas.Length; i++)
            {
                if (ventas[i] > mayorVenta)
                {
                    mayorVenta = ventas[i];
                    diaMayorVenta = i + 1; // +1 para ajustar al índice del día
                }
            }
            return diaMayorVenta;
        }
    }
}
