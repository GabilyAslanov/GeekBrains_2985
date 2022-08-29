using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

            int num = new Random().Next(1, 100000);
            // ViewSecondNumber(num);

            /*конец*/

            //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            System.Console.Write("Введите число: ");
            num = int.Parse(Console.ReadLine());

            System.Console.Write("Введите индекс: ");
            int numIndex = int.Parse(Console.ReadLine());

            ViewaThirdNumber1(num, numIndex);
            /*конец*/

            //Задача 15: Дано число обозначающее день недели. Выяснить является номер дня недели выходным

            // System.Console.Write("Введите день недели: ");
            // int dayWeek = int.Parse(Console.ReadLine());

            // DayOffWeek(dayWeek);

            /*конец*/

            // 9.1 Напишите программу, которая выводит случайное число из отрезка [10, 999] и показывает наибольшую цифру числа.
            // MaxNumber();

            // 9.2 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
            // MaxNumber2();

            //11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
            //RemoveMiddleNumber();

            // 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
            // SecondNumberMultipleFirst();
        }


        //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        static void ViewSecondNumber(int num)
        {
            if (num > 99 && num < 1000)
            {
                int secondNumber = (num / 10) % 10; //789/10= 78 %10=8

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
                //количество цифр в числе
                int length = (int)Math.Log10(num);
//456789
                //Дилитель числа на какое число мы должны поделить ,для того, чтобы получить число  
                int numberPow = (int)Math.Pow(10, length - index);
//10^6-3=1000
                //мы получаем нашу цифру
                int result = num / numberPow % 10;
//456789/1000= 456 %10=6
                Console.WriteLine($"{index} цифра в числе {num} -> {result}");
            }
            else
                Console.WriteLine($"У числа нет трёх цифр");
        }

        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        //То что дала GeekBrains
        //645 -> 5

        // 78 -> третьей цифры нет

        // 32679 -> 6
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

        // 9. Напишите программу, которая выводит случайное число из отрезка [10, 999] и показывает наибольшую цифру числа.
        static void MaxNumber()
        {
            int number1 = 798;// new Random().Next(10, 1000);

            int max = 0;

            int iterator = number1;
            //iterator = 798
            while (iterator != 0)
            {
                int number2 = iterator % 10;
                //number2=8
                if (number2 > max) max = number2;

                iterator /= 10;
                // iterator = iterator / 10;
                //iterator = 79
            }
            System.Console.WriteLine($"Number {number1} Max {max}");
        }
        // 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
        static void MaxNumber2()
        {
            int number = new Random().Next(10, 100);
            int number1 = number % 10;
            int number2 = number / 10;

            int max = number1;

            if (number1 < number2)
            {
                max = number2;
            }
            System.Console.WriteLine($"Number {number} Max {max}");
        }

        //11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
        static void RemoveMiddleNumber()
        {

            int number = new Random().Next(100, 1000);

            int result = ((number / 100) * 10) + (number % 10);

            System.Console.WriteLine($"Number={number};  result ={result} ");

        }

        // 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
        static void SecondNumberMultipleFirst()
        {
            System.Console.Write("Enter number1: ");
            int number1 = int.Parse(Console.ReadLine());

            System.Console.Write("Enter number2: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                if (number1 % number2 == 0)
                    System.Console.WriteLine($"Число {number2} кратное {number1}  ");
                else
                    System.Console.WriteLine($"Число {number2} не кратное {number1}  остататок {number1 % number2}");

                int number = 0;

            }
            else
            {
                System.Console.WriteLine($"Число {number2} больше {number1}  ");
            }
        }

    }
}
