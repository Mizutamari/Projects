using System;
using System.Collections.Generic;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { };
            for (int i = 0; i <= 99; i++)
            {
                for (int j = 98; j <= 1; j--)
                {
                    a[i] = j;
                }
            }

            var hanoi = new TowerOfHanoi<int>(a);
            hanoi.Solve();
            Console.WriteLine();
            hanoi.Show();
            Console.ReadLine();
        }

        public class TowerOfHanoi<T>
        {
            private Stack<T> left;
            private Stack<T> middle;
            private Stack<T> right;

            public TowerOfHanoi(int n)
            {
                left = new Stack<T>(n);
                middle = new Stack<T>(n);
                right = new Stack<T>(n);
            }

            public TowerOfHanoi(T[] array)
            {
                left = new Stack<T>(array);
                middle = new Stack<T>(array.Length);
                right = new Stack<T>(array.Length);
            }

            public void Reset()
            {
                left.Clear();
                middle.Clear();
                right.Clear();
            }

            public void Reset(int n)
            {
                left = new Stack<T>(n);
                middle = new Stack<T>(n);
                right = new Stack<T>(n);
            }

            public void Reset(T[] array)
            {
                left = new Stack<T>(array);
                middle = new Stack<T>(array.Length);
                right = new Stack<T>(array.Length);
            }

            public void Solve()
            {
                if (left.Count > 0) solve(left.Count - 1, left, middle, right);
            }

            private void solve(int disk, Stack<T> source, Stack<T> dest, Stack<T> aux)
            {
                if (disk == 0) move(source, dest);
                else
                {
                    solve(disk - 1, source, aux, dest);
                    move(source, dest);
                    solve(disk - 1, aux, dest, source);
                }
            }

            private void move(Stack<T> from, Stack<T> to)
            {
                to.Push(from.Pop());
                Show();
            }

            public void Show()
            {
                Console.Write(show(left));
                Console.Write(show(middle));
                Console.Write(show(right));
                Console.WriteLine();
            }

            private string show(Stack<T> stack)
            {
                var s = "[ ";
                var a = stack.ToArray();
                foreach (T t in a) s += t.ToString() + " ";
                s += "]";
                return s;
            }
        }
    }
}