using System;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5] { 1, 2, 3, 4, 5 };
            int[] vetorB = new int[5] { 1, 2, 3, 4, 5 };
            int[] vetorC = new int[5];

            int contador = 0;

            while (vetorA.Length > contador)
            {
                var _vetorA = vetorA[contador];
                var _vetorB = vetorB[contador];

                vetorC[contador] = _vetorA + _vetorB;

                contador++;
            }

            for (int i = 0; i < vetorC.Length; i++)
            {
                Console.WriteLine("Valor: " + vetorC[i]);
            }
        }
    }
}
