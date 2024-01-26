using System;

namespace ExemploMatriz 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o grau da matriz: "); int n = int.Parse(Console.ReadLine());
            int[,] mtz = new int[n,n];
            int neg = 0;

            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    Console.Write("Insira um inteiro" +"[" + (i + 1) + "]" + "[" + (j + 1) + "]" + ": "); int v = int.Parse(Console.ReadLine());
                    mtz[i, j] = v;
                    if (mtz[i, j] < 0)
                    {
                        neg++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mtz[i,i]);               
            }

            Console.WriteLine("Números negatvos: " + neg);
        }
    }
}