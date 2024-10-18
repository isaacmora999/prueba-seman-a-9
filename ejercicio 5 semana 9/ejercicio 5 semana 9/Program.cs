using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5_semana_9
{
    /*Escribe el programa que tenga una función que reciba un arreglo de enteros y lo
invierta (el primer elemento se convierte en el último, el segundo en el penúltimo,
etc.). Muestra el arreglo original y el invertido.
- No puedes utilizar métodos ya definidos en el lenguaje.
- Implementa una función que determine en el arreglo invertido, cuántos valores
impares existen y los imprima*/

    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar la longitud del arreglo
            Console.Write("Ingresa la cantidad de elementos en el arreglo: ");
            int n = int.Parse(Console.ReadLine());

            // Crear la lista y llenarla con los valores ingresados por el usuario
            List<int> lista = new List<int>();
            Console.WriteLine("Ingresa los valores de la lista:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                lista.Add(int.Parse(Console.ReadLine()));
            }

            // Mostrar la lista original
            Console.WriteLine("\nLista original:");
            LIstaManager.MostrarLista(lista);

            // Invertir la lista manualmente
            List<int> listaInvertida = LIstaManager.InvertirLista(lista);

            // Mostrar la lista invertida
            Console.WriteLine("\nLista invertida:");
            LIstaManager.MostrarLista(listaInvertida);

            // Contar e imprimir los números impares en la lista invertida
          
           LIstaManager.ContarImpares(listaInvertida);
      
            Console.ReadKey();
        }


        
    }
}