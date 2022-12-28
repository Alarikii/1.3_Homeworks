void FillArrayDouble(double[,] numbers, int MinValue = -10, int MaxValue = 10)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round(rand.NextDouble() * (MaxValue + Math.Abs(MinValue)) - Math.Abs(MinValue), 1);
        }
    }
}
void PrintArrayDouble(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FillArrayInt(int[,] numbers, int MinValue = 0, int MaxValue = 10)
{
    MaxValue++;
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = rand.Next(MinValue, MaxValue);
        }
    }
}
void PrintArrayInt(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами,
// округлёнными до одного знака.
void Task47()
{
    Console.WriteLine("=====   Задача 47  =====");
    int rows = 3;
    int columns = 4;
    double[,] numbers = new double[rows, columns];
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
    Console.WriteLine();
    Console.WriteLine();
}

// Задача 50: Напишите программу, которая на вход
// принимает индексы элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
void Task50()
{
    Console.WriteLine("=====  Задача 50  =====");
    int rows = 3;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArrayInt(numbers);
    PrintArrayInt(numbers);
    Console.WriteLine("Введите индекс нужной строки");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс нужного столбца");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i < rows && j < columns) Console.WriteLine("Выбранный элемент массива " + numbers[i, j]);
    else Console.WriteLine("Введены неправильные индексы");
    Console.WriteLine();
    Console.WriteLine();
}

// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
void Task52()
{
    Console.WriteLine("=====  Задача 52  =====");
    int rows = 3;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArrayInt(numbers);
    PrintArrayInt(numbers);
    double sum = 0;
    double mean = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            sum = sum + numbers[i, j];
        }
        mean = Math.Round((sum / rows), 1);
        Console.Write(mean + ";  ");
        sum = 0;
    }
}

Task47();
Task50();
Task52();

