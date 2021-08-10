using System;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
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

            for (int i = numeros.Length - 1; i > -1; i--)
            {
                Console.WriteLine("Valor: " + numeros[i]);
            }
        }
    }
}
