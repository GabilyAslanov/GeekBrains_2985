
//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

double[,] arrayDouble = GetArrayDouble(rows, columns, 0, 10);
PrintArrayDouble(arrayDouble);

double[,] GetArrayDouble(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(max-min);
        }
    }
    return result;
}

void PrintArrayDouble(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]:f1} ");
        }
        Console.WriteLine();
    }
}

//Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает информацию о наличии этого элемента в массиве.

Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
 columns=int.Parse(Console.ReadLine());


int[,] array = GetArray(rows, columns,0,10);
PrintArray(array);
Console.Write("Введите значение элемента: ");
int element=int.Parse(Console.ReadLine());
if(FindElement(array,element))
{
    Console.WriteLine("Элемент найден");
}
else
{
    Console.WriteLine("Элемент не найден");
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


bool FindElement(int[,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j]==el) return true;
        }
    }
    return false;
}

//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.


Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
 columns = int.Parse(Console.ReadLine());
 array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] averageColumns=GetResultArray(array);
Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ",averageColumns)}");





double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum=0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum+=array[j,i];
        }
        result[i]=Math.Round(sum/array.GetLength(0),2);
    }
    return result;
}


//Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
 columns = int.Parse(Console.ReadLine());
 array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] rowAr=GetRowArray(array);
SortArray(rowAr);
Console.WriteLine(String.Join(" ",rowAr));
PrintData(rowAr);



int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0)*inArray.GetLength(1)];
    int index=0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i,j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i+1; j < inArray.Length; j++)
        {
            if(inArray[i]>inArray[j])
            {
                int k=inArray[i];
                inArray[i]=inArray[j];
                inArray[j]=k;
            }
        }
    }
}




void PrintData(int[] inArray)
{
    int el=inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if(inArray[i]!=el)
        {
            Console.WriteLine($"{el} встречается {count}");
            el=inArray[i];
            count=1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{el} встречается {count}");
}

//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
 columns=int.Parse(Console.ReadLine());

array = GetArraySum(rows, columns);
PrintArray(array);

int[,] GetArraySum(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i+j;
        }
    }
    return result;
}

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
 columns=int.Parse(Console.ReadLine());

 array = GetArray(rows, columns,0,10);
PrintArray(array);
Console.WriteLine();
PrintArray(ChangeArray(array));



int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i > 0 && i % 2 == 0 && j > 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
}


Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
 columns=int.Parse(Console.ReadLine());

 array = GetArray(rows, columns,0,10);
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали = {GetSumDiag(array)}");


int GetSumDiag(int[,] array)
{
    int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += array[i, i];
    }
    return sum;
}



//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
Console.Clear();

Console.Write("Введите количество строк массива: ");
 rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
 columns = int.Parse(Console.ReadLine());

array = GetArray(rows, columns, 0, 10);
PrintArray(array);


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }




//метод возвращающий индекс опорного элемента
int Partition(int[] array, int minIndex, int maxIndex)
{
    var pivot = minIndex - 1;//-1
    for (var i = minIndex; i < maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivot++;
           
            var tmp = array[pivot];
            array[pivot] = array[i];
            array[i] = tmp;
        }
    }

    pivot++;

    var temp = array[pivot];
    array[pivot] = array[maxIndex];
    array[maxIndex] = temp;
    return pivot;
}

//быстрая сортировка
int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return array;
    }

    var pivotIndex = Partition(array, minIndex, maxIndex);
    QuickSort(array, minIndex, pivotIndex - 1);
    QuickSort(array, pivotIndex + 1, maxIndex);

    return array;
}

// int[] GetArray(int size = 12, int minValue = -100, int maxValue = 100)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }


// var arr = GetArray();

// Console.WriteLine("Mассив: {0}", string.Join(", ", arr));
// var arraySort= QuickSort(arr,0, arr.Length - 1);
// Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", arraySort));

// Console.ReadLine();
