using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4_sem_9
{
    /*Crea un programa que use un arreglo estático para almacenar números y una función
que calcule el factorial de cada número, el cual es enviado a un segundo arreglo.
Muestra los resultados, es decir ambos arreglos
- El número es leído en la función principal Main y es enviado como parámetro a la
función que calcula el factorial. Recuerda que el factorial no se calcula para números
negativos. Por lo tanto, al arreglo original sólo debes guardar los números positivos
o cero.
- El programa se repetirá mientras el usuario lo desea.*/
    class Program
    {
        static int[] numeros = new int[MAX_SIZE]; // Arreglo estático para números
        static long[] factoriales = new long[MAX_SIZE]; // Arreglo estático para factoriales
        static int contador = 0;
        const int MAX_SIZE = 10; // Tamaño máximo de los arreglos

        static void Main(string[] args)
        {
            char continuar;

            do
            {
                if (contador >= MAX_SIZE)
                {
                    Console.WriteLine("Has alcanzado el límite de números permitidos.");
                    break;
                }

                Console.Write("Ingresa un número (positivo o cero): ");
                int numero = int.Parse(Console.ReadLine());

               
                if ( numero >= 0)
                {
                    // Guardar el número y calcular su factorial usando la clase FactorialCalculator
                    numeros[contador] = numero;
                    factoriales[contador] = factorial.CalcularFactorial(numero);
                    contador++;

                    factorial.MostrarResultados(numeros, factoriales, contador);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Solo se permiten números positivos o cero.");
                }

                Console.Write("¿Deseas ingresar otro número? (s/n): ");
                continuar = Console.ReadLine().ToLower()[0];

            } while (continuar == 's');

            // Llamamos a la función para mostrar los resultados desde la clase FactorialCalculator
            factorial.MostrarResultados(numeros, factoriales, contador);
        }
    }

}








