using System;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
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
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine("Valor: " + numeros[i]);
                }
            }
        }
    }
}
