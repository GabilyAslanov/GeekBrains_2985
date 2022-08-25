using System;

namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = new Random().Next(1, 100000);
            //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

            // ViewSecondNumber(num);

            //

            //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            // System.Console.Write("Введите число: ");
            // num = int.Parse(Console.ReadLine());

            // System.Console.Write("Введите индекс: ");
            // int numIndex = int.Parse(Console.ReadLine());

            // ViewaThirdNumber1(num, numIndex);
            // //

            // //Задача 15: Дано число обозначающее день недели. Выяснить является номер дня недели выходным

            // System.Console.Write("Введите день недели: ");
            // int dayWeek = int.Parse(Console.ReadLine());

            // DayOffWeek(dayWeek);

            //
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
        //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        static void ViewSecondNumber(int num)
        {
            if (num > 99 && num < 1000)
            {
                int secondNumber = num / 10 % 10;

                Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");
            }
            else
                Console.WriteLine($"Число {num} не трёхзначное");
        }

        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        static void ViewaThirdNumber1(int num, int index)
        {
            if (num > 99)
            {
                int length = (int)Math.Log10(num) + 1;

                int numberPow = (int)Math.Pow(10, length - index);

                int result = num / numberPow % 10;

                Console.WriteLine($"{index} цифра в числе {num} -> {result}");
            }
            else
                Console.WriteLine($"У числа нет трёх цифр");
        }

        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        //То что дала GeekBrains
        static void ViewaThirdNumber2(int num, int index = 3)
        {
            Console.Clear();

            if (num < 100)
            {
                Console.WriteLine($"Третьей цифры нет");
                return;
            }
            int thirdNumber = (num / 100) % 10;
            Console.WriteLine($"Третья цифра числа {num} -> {thirdNumber}");
        }

        //Задача 15: Дано число обозначающее день недели. Выяснить является номер дня недели выходным
        static void DayOffWeek(int dayWeek)
        {
            switch (dayWeek)
            {
                case 1:
                    Console.WriteLine("Понедельник- НЕТ");
                    break;
                case 2:
                    Console.WriteLine("Вторник- НЕТ");
                    break;
                case 3:
                    Console.WriteLine("Среда- НЕТ");
                    break;
                case 4:
                    Console.WriteLine("Четверг- НЕТ");
                    break;
                case 5:
                    Console.WriteLine("Пятница- Да");
                    break;
                case 6:
                    Console.WriteLine("Суббота- Нет");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье- Нет");
                    break;
                default:
                    Console.WriteLine("Некорректный номер дня недели");
                    break;
            }
        }
    }


}
