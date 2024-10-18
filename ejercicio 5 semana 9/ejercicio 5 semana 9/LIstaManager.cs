using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5_semana_9
{
    internal class LIstaManager
    {
        public static void MostrarLista(List<int> lista)
        {
            foreach (int num in lista)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Función para invertir la lista manualmente
        public static List<int> InvertirLista(List<int> lista)
        {
            List<int> invertida = new List<int>();
            int n = lista.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                invertida.Add(lista[i]);
            }
            return invertida;
        }

        // Función para contar los números impares en la lista invertida
        public static void ContarImpares(List<int> lista)
        {
            int contadorImpares = 0;
            Console.WriteLine("\nNúmeros impares en la lista invertida:");
            foreach (int num in lista)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                    contadorImpares++;
                }
            }
            Console.WriteLine($"\nTotal de números impares: {contadorImpares}");
        }
    }
}

