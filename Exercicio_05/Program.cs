using System;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorOrdemInversa = new int[50];           

            for (int i = 0; i < vetorOrdemInversa.Length; i++)
            {
                Random r = new Random();
                vetorOrdemInversa[i] = r.Next(0, int.MaxValue);
            }

            Console.WriteLine("Ordem normal");
            for (int i = 0; i < vetorOrdemInversa.Length; i++)
            {

                Console.WriteLine("Valor: " + vetorOrdemInversa[i]);
            }

            Console.WriteLine("Ordem inversa");
            for (int i = vetorOrdemInversa.Length - 1; i > -1; i--)
            {

                Console.WriteLine("Valor: " + vetorOrdemInversa[i]);
            }
        }
    }
}
