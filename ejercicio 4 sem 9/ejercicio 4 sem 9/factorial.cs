using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4_sem_9
{
    internal class factorial
    {
        public static long CalcularFactorial(int num)
        {
            if (num == 0)
                return 1;

            long factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        // Método para mostrar los resultados
        public static void MostrarResultados(int[] numeros, long[] factoriales, int cantidad)
        {
            Console.WriteLine("\nResultados:");
            Console.WriteLine("Número\tFactorial");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"{numeros[i]}\t{factoriales[i]}");
            }
        }
    }
}
