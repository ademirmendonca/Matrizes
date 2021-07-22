using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faz a leitura do valor da matriz
            int n = int.Parse(Console.ReadLine());

            /*Cria a estrutura da matriz, no caso terá o número de
            linha a mesma quantidade de colunas, porque é uma matriz quadrada.*/
            int[,] a = new int[n, n];

            //Primeiro for, para percorrer as linhas, segundo for percorre as colunas
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    //linha "i", é igual a coluna "J".
                    a[i, j] = int.Parse(vet[j]);
                }
            }

            //Imprime os valores da matriz na diagonal
            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i, i] + " ");
            }

            //Para pular uma linha
            Console.WriteLine("");

            //Conta e imprime a quantidade de números negativos.
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                
                //Percorrer todas as linhas para verificar se há números negativos.
                for (int j = 0; j < n; j++)
                {                    
                    if (a[i,j] < 0)
                    {
                        //Cont++ para fazer a soma de cont + cont.
                        cont++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);

        }
    }
}
