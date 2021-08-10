using System;

namespace Exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaJogadores = new string[,] {
                                        { "Juca", "2" },
                                        { "Teo", "2,1" },
                                        { "Lucas", "2" },
                                        { "Lima", "2" },
                                        { "Edu", "2" },
                                        { "Bruno", "2" },
                                        { "Rogério", "2" },
                                        { "Mário", "2" },
                                        { "João", "2" },
                                        { "Ademir", "2" },
                                        { "Ricardo", "2" },
                                        { "Luiz", "2" }
            };

            float maiorAltura = 0;
            string jogador = "";
            double mediaAltura = 0;

            for (int i = 0; i < listaJogadores.Length / 2; i++)
            {
                if (maiorAltura < float.Parse(listaJogadores[i, 1]))
                {
                    maiorAltura = float.Parse(listaJogadores[i, 1]);
                    jogador = listaJogadores[i, 0];

                }

                mediaAltura += float.Parse(listaJogadores[i, 1]);
            }           

            Console.WriteLine("Jogador mais alto: " + jogador + " - altura: " + maiorAltura);
            Console.WriteLine("Media de altura: " + mediaAltura / 12);
            Console.WriteLine("Jogadores acima da média: " );

            for (int i = 0; i < listaJogadores.Length / 2; i++)
            {
                if (mediaAltura / 12 < float.Parse(listaJogadores[i, 1]))
                {
                    Console.WriteLine("Jogador: " + listaJogadores[i,0] + " - altura: " + listaJogadores[i, 1]);
                }
            }
        }
    }
}
