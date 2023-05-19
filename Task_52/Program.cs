// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();

Console.Write("Введите колличество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? " ");

Console.Write("Введите колличество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? " ");

int[,] array = GetArray(rows, colums, 0, 9);
PrintArray(array);
SearchArefmeticalMean(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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
            Console.Write($"{inArray[i, j]} | ");
        }
        Console.WriteLine();
    }
}

void SearchArefmeticalMean(int[,] array)
{
    Console.WriteLine("---------------------------");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); i++)

        {
            sum = sum + array[i, j];
            Console.Write($"{sum / array.GetLength(0)} | ");
        }
        Console.WriteLine();
    }
}
