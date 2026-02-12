using System;
using System.Collections.Generic;

namespace EjerciciosCS
{
    /// <summary>
    /// Ejercicios de C# para practicar Arrays y Listas
    /// </summary>
    public class Ejercicios
    {
        private int[] _arrayGenerado = Array.Empty<int>();
        
        public double CalcularPromedioTemperatura()
        {
         double[] Temperaturas = { 22.1, 16.5, 25.2, 30.7, 36.3 };
            double promedio = 0.0;
            double suma = 0.0;

            for (int i = 0; i < Temperaturas.Length; i++)
            {
                suma += Temperaturas[i];
            }
            promedio = suma / Temperaturas.Length;
            // TODO: Implementar el cálculo del promedio de temperaturas  
            return promedio;
        }

        public List<string> CrearListaCompras()
        {
            // TODO: Implementar la lista de compras interactiva
            List<string> listaCompras = new List<string>();
             Console.WriteLine("Ingrese productos uno por uno. Escriba 'salir' para terminar.");

            while (true)
            {
                Console.Write("Producto: ");
                string input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                    continue;

                if (input.ToLower() == "salir")
                    break;

                listaCompras.Add(input);
            }

            Console.WriteLine("\nProductos ingresados:");
            foreach (string producto in listaCompras)
                Console.WriteLine("- " + producto);

            return listaCompras;
        }

        /// <summary>
        /// 3. EL BUSCADOR (Reto)
        /// 
        /// PISTAS:
        /// - Crea un 'Random' para generar números aleatorios
        /// - Crea un array de 'int' con 10 elementos
        /// - Usa un bucle 'for' para llenar el array con números aleatorios (0-100)
        ///   Puedes usar: random.Next(0, 101)
        /// - Recorre el array con otro bucle 'for' buscando el número de la variable 'numeroBuscado'
        /// - Si encuentras el número, retorna 'true'
        /// - Si terminas el bucle sin encontrarlo, retorna 'false'
        /// 
        /// BONUS: Muestra los números generados en el array
        /// </summary>
        ///param name="numeroBuscados">El número que el usuario quiere buscar</param>
        /// <returns>true si el número está en el array, false si no</returns>
        public bool BuscarNumeroDinamico(int numeroBuscado)
        {
           bool encontrado = false;
    Random random = new Random();

    int[] numeros = new int[10];

    for (int i = 0; i < numeros.Length; i++)
        numeros[i] = random.Next(0, 101);

    Console.WriteLine("Números generados:");
    foreach (int n in numeros)
        Console.Write(n + " ");
    Console.WriteLine();

    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] == numeroBuscado)
        {
            encontrado = true;
            break;
        }
    }

    return encontrado;


        }

        
    }
}
