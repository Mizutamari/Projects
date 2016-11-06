using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zestaw_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Zadanie 1
            int age = 21;
            string name = "Łukasz";
            string number = "IBI/3"; 
            string surname = "Kałuża";

            Console.WriteLine("Imię: " + name + " Nazwisko: " + surname);
            Console.WriteLine("Wiek: " + age + " lat Nr grupy: " + number);
            Console.ReadKey();
            */
            /*
            //Zadanie 2
            Console.WriteLine("Podaj liczbę a: ");
            string a = Console.ReadLine();
            double number_1 = double.Parse(a);

            Console.WriteLine("Podaj liczbę b: ");
            string b = Console.ReadLine();
            double number_2 = double.Parse(b);

            double dodaj = double.Parse(a) + double.Parse(b);
            Console.WriteLine(a + "+" + b + "=" + dodaj);

            double odejmij = double.Parse(a) - double.Parse(b);
            Console.WriteLine(a + "-" + b + "=" + odejmij);

            double pomnoz = double.Parse(a) * double.Parse(b);
            Console.WriteLine(a + "*" + b + "=" + pomnoz);

            double podziel = double.Parse(a) / double.Parse(b);
            Console.WriteLine(a + "/" + b + "=" + podziel);

            Console.ReadKey();
            */

            //Zadanie 3
            /*Console.WriteLine("Podaj wartość do przeliczenia: ");
            string value = Console.ReadLine();
            double val = double.Parse(value);
            


            Console.ReadKey();*/
            //Zadanie 4
            /*Console.WriteLine("Podaj wartość w stopniach: ");
            string value = Console.ReadLine();
            double val = double.Parse(value);

            double rad;
            char degree = (char)176;
            rad = val * 3.14 / 180;
            Console.WriteLine(val + "[" + degree + "]" + "=>" + rad + "[rad]");
            Console.ReadKey();*/

            //Zadanie 5
            Console.WriteLine("Podaj a1, b1, c1 dla równania a1x + b1y = c1: ");
            string a1 = Console.ReadLine();
            int val1 = int.Parse(a1);
            string b1 = Console.ReadLine();
            int val2 = int.Parse(b1);
            string c1 = Console.ReadLine();
            int val3 = int.Parse(c1);

            Console.WriteLine("Podaj a2, b2, c2 dla równania a2x + b2y = c2: ");
            string a2 = Console.ReadLine();
            int val4 = int.Parse(a2);
            string b2 = Console.ReadLine();
            int val5 = int.Parse(b2);
            string c2 = Console.ReadLine();
            int val6 = int.Parse(c2);

            double wyznacznik, wyznacznik_x, wyznacznik_y;

            wyznacznik = (val1 * val5) - (val2 * val4);
            wyznacznik_x = (val3 * val5) - (val2 * val6);
            wyznacznik_y = (val1 * val6) - (val3 * val4);

            if (wyznacznik != 0)
            {
                Console.WriteLine("Układ równań jest oznaczony, czyli posiada jedno rozwiązanie.");
                double x = wyznacznik_x / wyznacznik;
                double y = wyznacznik_y / wyznacznik;
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            else if (wyznacznik == 0 && wyznacznik_x == 0 && wyznacznik_y == 0)
            {
                Console.WriteLine("Układ równań jest nieoznaczony, czyli posiada nieskończenie wiele rozwiązań.");
            }
            else if (wyznacznik == 0)
            {
                if (wyznacznik_x != 0 || wyznacznik_y != 0)
                {
                    Console.WriteLine("Układ równań jest sprzeczny, czyli nie ma rozwiązań.");
                }
            }
            Console.ReadKey();


        }
    }
}
