using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1EstDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Pedir la primera lista de datos
            Console.WriteLine("Digite la primera lista de numeros:");
            string[] firstSet = Console.ReadLine().Split(' ');

            // Pedir la segunda lista de datos
            Console.WriteLine("Digite la segunda lista de numeros:");
            string[] secondSet = Console.ReadLine().Split(' ');

            // Unir las dos listas a una sola 
            string[] combinedSet = firstSet.Concat(secondSet).ToArray();

            // Pasar los valores de la lista a numeros 
            List<int> numbers = new List<int>();
            foreach (string numberString in combinedSet)
            {
                if (int.TryParse(numberString, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine($"Datos no son numeros: {numberString}");
                }
            }

            // Ordenar los numeros 
            numbers.Sort();

            // Imprimir lista
            Console.WriteLine("Lista de numeros ordenados:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine(); // Esperar que el usuario aprete enter 

        }
    }
}
