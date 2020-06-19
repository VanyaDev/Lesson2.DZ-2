using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Продвинутый уровень. Задание №166
            */

            Console.WriteLine("Введите числа:"); // вводить: надо первое число, Enter и следующее число

            int s;

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && c > b)
            {
                s = a + c;
                Console.WriteLine(s);
            }
            if (b > a && c > a)
            {
                s = b + c;
                Console.WriteLine(s);
            }
            if (a > b && b > c)
            {
                s = a + b;
                Console.WriteLine(s);
            }
            if (b > a && a > c)
            {
                s = b + a;
                Console.WriteLine(s);
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();


            /*
             * Продвинутый уровень. Задание №60
             */

            Console.WriteLine("Введите растояние в километрах: ");

            int V;
            int X;

            int km = int.Parse(Console.ReadLine());
            float ft = float.Parse(Console.ReadLine());
            _ = km * 1000;
            _ = ft * 0.31;
            
            if (km > ft)
            {
                Console.WriteLine("Растояние в километрах больше чем в футах");
             }
            else
            {
                Console.WriteLine("Растояние в километрах меньше чем в футах");
            }

            Console.WriteLine("Press any key");
            Console.ReadLine();
            Console.Clear();

            /*
             * Продвинутый уровень. Задания №139 и 140.
             */

            Console.WriteLine("Введите стороны любого треугольника, чтобы определить его свойства");

            // Вводим первую сторону треугольника                                                                    
            Console.WriteLine("Первая сторона равна:");
            string z = Console.ReadLine();
            int N = Convert.ToInt32(z);

            // Вводим вторую сторону треугольника
            Console.WriteLine("Вторая сторона равна:");
            Console.ReadLine();
            int L = Convert.ToInt32(z);

            //Вводим третью сторону треугольника 
            Console.WriteLine("Третья сторона равна:");
            Console.ReadLine();
            int M = Convert.ToInt32(z);


            if (N == L & N == M & M == L)
            {
                Console.WriteLine("Данный треугольник является равносторонним");
            }
            else
                if (N == L | N == M | L == M)
            {
                Console.WriteLine("Данный треугольник является равнобедренным");
            }
            else
                    if ((N * N) + (L * L) == (M * M) | (N * N) + (M * M) == (L * L) | (M * M) + (L * L) == (N * N))
            {
                Console.WriteLine("Данный треугольник является прямоугольным");
            }
            Console.ReadKey();
        }
      }
  }

  





