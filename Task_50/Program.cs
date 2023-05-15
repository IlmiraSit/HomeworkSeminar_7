// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int rows = UserNum("Введите позицию строки: ");
int colums = UserNum("Введите позицию столбца: ");

int[,] numbers = new int[10, 10];
FillArray(numbers);
PrintArray(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows},{colums} -> такого числа в массиве нет");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int UserNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? " ");
}