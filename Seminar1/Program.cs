// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 4
// Console.Write("Enter number:");
// // convert = конвертирует string в другую переменную
// int number = Convert.ToInt32(Console.ReadLine());

// int value = number * number;

// System.Console.WriteLine("square number:"+value);

// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


// System.Console.Write("Enter first number : ");
// int squareNumber = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter last number : ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(squareNumber == number * number)
// {
// Console.WriteLine( "Yes");
// }
// else
// {
// Console.WriteLine( "No");
// }


// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Enter number : ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number >= 1 && number <= 7 )
// {

// switch(number)
// {
// case 1: System.Console.WriteLine("Monday"); break;

// case 2: System.Console.WriteLine("Tuesday"); break;

// case 3: System.Console.WriteLine("Wednesday"); break;

// default: System.Console.WriteLine("Bad number");  break;
// }

// if(number == 1){
// System.Console.WriteLine("Monday");
// }  
// else if(number == 2){
//  System.Console.WriteLine("Tuesday");
// }
// else if(number == 3){
// System.Console.WriteLine("Wednesday");
// }
// else{
//     System.Console.WriteLine("Bad number"); 
// }

// }
// else
// {
// System.Console.WriteLine("Bad Number");
// }

// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
// Итерация №2

// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.Write("Enter number : ");

// int number = Convert.ToInt32(Console.ReadLine());

// int number2 = - number;
// int number2 = number * (-1);
// while(number2 <= number){

// // Console.Write($"{number2},");
// Console.Write(number2 + ",");

// ++number2;

// }

Console.Write("Enter number : ");

int number = Convert.ToInt32(Console.ReadLine());

if(((number / 100) > 0) && ((number / 1000) < 1) ){
int lastNumber = number % 10;
System.Console.WriteLine( "Last number : "+ lastNumber);
}
else{
    System.Console.WriteLine("Bad number");
}
