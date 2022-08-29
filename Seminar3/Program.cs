using System;

namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {

            //ViewQuarterNumber();

            //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

                Console.Write("Введите X1: ");
                int x1 = int.Parse(Console.ReadLine());
                Console.Write("Введите Y1: ");
                int y1 = int.Parse(Console.ReadLine());
               Console.Write("Введите X2: ");
                int x2 = int.Parse(Console.ReadLine());
                Console.Write("Введите Y2: ");
                int y2 = int.Parse(Console.ReadLine());

                DistanceBetweenPoints(x1, x2, y1, y2);
            //

        }

        //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
        static void DistanceBetweenPoints(int x1, int x2, int y1, int y2)
        {
            double distanceBetweenPoints = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            Console.WriteLine($"Distance Between Points={distanceBetweenPoints:f2}");
        }

        //Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
        static void SquaresTable(int number)
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write($"{i * i} ");
            }
        }

        //17. Напишите программу, которая принимает на вход координаты точки (X и Y),
        //причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
        static void ViewQuarterNumber()
        {
            Console.Write("Введите X: ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Введите Y: ");
            int Y = int.Parse(Console.ReadLine());

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("1 четверть");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("2 четверть");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("3 четверть");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("4 четверть");
            }
        }


        //Задача 18: Напишите программу, которая по заданному номеру четверти, 
        //показывает диапазон возможных координат точек в этой четверти (x и y).
        static void ViewRangePossibleCoordinates()
        {
            //Напишите программу, которая по заданному номеру четверти, 
            //показывает диапазон возможных координат точек в этой четверти (x и y).
            Console.Clear();
            Console.Write("Введите номер четверти: ");
            int quarter = int.Parse(Console.ReadLine());

            switch (quarter)
            {
                case 1:
                    {
                        Console.WriteLine("x>0 y>0");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("x<0 y>0");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("x<0 y<0");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("x>0 y<0");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Введена неправильная четверть");
                        break;
                    }
            }
        }

    }


}
