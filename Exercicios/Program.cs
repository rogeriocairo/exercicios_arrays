using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] numeros = new int[50];
            int contador = 0;

            while (numeros.Length > contador)
            {
                try
                {
                    numeros[contador] = Convert.ToInt32(Console.ReadLine());

                    contador++;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message); ;
                }
            }


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Elemento: " + i + " valor: " + numeros[i]);
            }
        }
    }
}
