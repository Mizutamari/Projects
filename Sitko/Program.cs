using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sitko
{
    class Program
    {
        static void Main(string[] args)
        {
            var min = SitoEratostenesa.ObliczSitko(8);
            foreach (int i in min) Console.Write(i + " ");
            Console.ReadLine();
        }
    }

    public static class SitoEratostenesa
    {
        public static int[] ObliczSitko(int n)
        {
            int[] array = new int[n - 1];

            List<int> list = new List<int>();

            for (int i=0; i< array.Length; i++)
            {
                array[i] = i;
                list.Add(i);
            }

            return array.ToList();
        }
    }
}
