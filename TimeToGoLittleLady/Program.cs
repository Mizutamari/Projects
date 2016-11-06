using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeToGoLittleLady
{
    class Program
    {
        static void Main(string[] args)
        {
            var littleLady = TimeToGoLittleLady.TimeToGo(20);
            foreach (var i in littleLady) Console.Write(i + " ");
            Console.ReadLine();
        }
    }

    public static class TimeToGoLittleLady
    {
        public static int[] TimeToGo(int littleLady)
        {
            int[] array = new int[littleLady - 1];

            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                list.Add(i);
            }

            return array.ToList();
        }
    }
}
