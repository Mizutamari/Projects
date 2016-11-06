using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SitoEratostenesa
{
    class Program
    {
    }

    public class SitoEratostenesa
    {
        public static int[] ObliczSito(int n)
        {
            int[] table = new int[n-1];

            for (int i = 2; i <= table.Length; i++)
            {
                if (table.Length > 1)
                {
                    table[i] = i;
                    Console.WriteLine(table[i]);
                }
            }

            int min = 0;
            int wlk = 0;

            for (int i = 0; i < table.Length; i++)
            {
                if (min >= table[i])
                {
                    min = table[i];
                    Console.WriteLine("\nElement minimalny wynosi {1} \n", i, min);

                    for (int j = 0; j < n; j++)
                    {
                        wlk = table[i] * j;
                        Console.WriteLine("Wielokrotność {0} to: {1} ", table[i], wlk);
                    }
                }
            }

            //List<int> tmp = new List<int>();
            //return tmp.ToArray();
        }
    }
}
