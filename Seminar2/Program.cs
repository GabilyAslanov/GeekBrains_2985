using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9.1 Напишите программу, которая выводит случайное число из отрезка [10, 999] и показывает наибольшую цифру числа.
            MaxNumber();

            // 9.2 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
            MaxNumber2();

            //11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
            RemoveMiddleNumber();

            // 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
            SecondNumberMultipleFirst();
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
