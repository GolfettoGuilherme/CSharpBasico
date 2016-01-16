using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] minhaMatriz = new int[2, 4];
            int numero = 0;
            //duas linhas e 4 colunas

            for(int i = 0; i <= 1; i++)
            {
                for(int j = 0; j <= 3; j++)
                {
                    minhaMatriz[i, j] = numero;
                    numero++;
                }
            }

            for(int i = 0; i <= 1; i++)
            {
                for(int j = 0; j <= 3; j++)
                {
                    Console.WriteLine("[{0}][{1}] = {2}", i, j, minhaMatriz[i, j]);
                }
            }
            Console.WriteLine("Quantidade de dimensoes = {0}", minhaMatriz.Rank);
            Console.ReadKey();

        }
    }
}
