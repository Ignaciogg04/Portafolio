using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidad_1_semana_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int e;
            int f;
            double g;
            double h;
            double i;

            Console.WriteLine("Ingrese la primera cantidad");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Si la cantidad es en quetzales, escriba 1; si la cantidad es en dólares, escriba 2");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda cantidad");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Si la cantidad es en quetzales, escriba 1; si la cantidad es en dólares, escriba 2");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera cantiadad");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Si la cantidad es en quetzales, escriba 1; si la cantidad es en dólares, escriba 2");
            f = int.Parse(Console.ReadLine());


            if (d == 2)
            {
                g = (a * 7.83);
            }
            else
            {
                g = a;
            }

            if (e == 2)
            {
                h = (b * 7.83);
            }
            else
            {
                h = b;
            }

            if (f == 2)
            {
                i = (c * 7.83);
            }
            else
            {
                i = c;
            }

            if ((a < b) && (a < c))
            {
                Console.WriteLine("El número menor es: " + g);
            }
            else if ((a > b) && (a < c))
            {
                Console.WriteLine("El número de en medio es: " + g);
            }

            else if ((a < b) && (a < c))
            {
                Console.WriteLine("El número de en medio es: " + g);
            }
            else
            {
                Console.WriteLine("El número mayor es: " + g);
            }
            if ((b < a) && (b < c))
            {
                Console.WriteLine("El número menor es: " + h);
            }
            else if ((b > a) && (b < c))
            {
                Console.WriteLine("El número de en medio es: " + h);
            }
            else if ((b < c) && (b < c))
            {
                Console.WriteLine("El número de en medio es: " + h);
            }
            else
            {
                Console.WriteLine("El número mayor es: " + h);
            }

            if ((c < b) && (c < a))
            {
                Console.WriteLine("El número menor es: " + i);
            }
            else if ((c > b) && (c < a))
            {
                Console.WriteLine("El número de en medio es: " + i);
            }

            else if ((c < b) && (c < a))
            {
                Console.WriteLine("El número de en medio es: " + i);
            }
            else
            {
                Console.WriteLine("El número mayor es: " + i);
            }
            Console.ReadKey();

        }
    }
}
