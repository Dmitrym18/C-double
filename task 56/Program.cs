// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = GetArray(3, 3);
array = FillArrayRandom(array);
PrintArray(array);
int row = SumRowArray(array);
Console.WriteLine($"Наименьшая сумма в {row} строке.");


int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int SumRowArray(int[,] array)
{
    int[] sumArr = new int[array.GetLength(0)];
    Console.WriteLine($"Сумма по строке:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArr[i] += array[i, j];
        }
        Console.WriteLine($"{i + 1} -> {sumArr[i]}");
    }
    int minSum = sumArr[0];
    int minRow = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (sumArr[i] < minSum)
        {
            minSum = sumArr[i];
            minRow = i + 1;
        }
    }
    return minRow;
}