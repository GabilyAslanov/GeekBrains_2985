//Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Cумма цифр = {GetSumNums2(num)}");


int GetSumNums1(int number)
{
    //1+1
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int GetSumNums2(int number)
{
    int result = 0;

    for (int i = 1; i <= number; i++)
    {
        result += i;
    }

    return result;

}
/*конец*/

//Напишите программу, которая принимает 
//на вход число N и выдаёт количество цифр в числе.

Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр = {GetCountNums(num)}");


int GetCountNums(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }
    return count;
}
/*конец*/

//Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.

Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");


int GetMultiply(int number)
{
    int result = 1;
    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }
    return result;
}
/*конец*/

//Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }

    return result;
}
/*конец*/