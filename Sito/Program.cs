using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sito
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n;
            Console.WriteLine("Wprowadź n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("N wynosi {0}", n);
            Console.ReadLine();*/

            var tmp = SitoEratostenesa.ObliczSito(2325484);
            foreach (int i in tmp) Console.Write(i + " ");
            Console.ReadLine();
        }
    }

    public class SitoEratostenesa
    {
        public int[] ObliczSito(int n)
        {
            if (n > 3)
            {
                //var list = new List<int>();
                var tmp = 2;
                var max = (int)Math.Floor(Math.Sqrt(n));
                var array = new int[n - 1];
                var arrayofelements = new List<int>(array);
                for (var i = 0; i < array.Length; i++) array[i] = i + 2;
                while (tmp <= max)
                {
                    for (var i = (tmp * 2) - 2; i < array.Length; i += tmp)
                    {
                        array[i] = 0;
                    }
                    tmp++;
                }
                for (var i = 0; i < array.Length; i++)
                    if (array[i] != 0)
                        arrayofelements.Add(array[i]);
                return arrayofelements.ToArray();
            }
            else if (n == 3)
            {
                return new int[] { 2, 3 };
            }
            else if (n == 2)
            {
                return new int[] { 2 };
            }
            else return null;
        }
    }
}
