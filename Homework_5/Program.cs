void FillArray(int[] array, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minValue, maxValue);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine("Вывод матрицы: ");
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write(array[i] + "  ");

    }
    Console.WriteLine();
    Console.WriteLine();
}
void FillArrayDouble(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * 20 - 10, 2);
    }
}
void PrintArrayDouble(double[] array)
{
    Console.WriteLine("Вывод матрицы: ");
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write(array[i] + "  ");

    }
    Console.WriteLine();
    Console.WriteLine();
}

// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
void Task34()
{
    int size = 4;
    int[] array = new int[size];
    FillArray(array, 100, 999);
    PrintArray(array);
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2  == 0) count++;
    }
    Console.WriteLine("Количество четных элементов: " + count);
}

// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов с
// нечётными индексами.
void Task36()
{
    int size = 5;
    int[] array = new int[size];
    FillArray(array, -100, 100);
    PrintArray(array);
    int sumNegIndex = 0;
    for (int i = 1; i < array.Length; i +=2)
    {
        sumNegIndex = sumNegIndex + array[i];
    }
    Console.WriteLine("Сумма элементов с нечетными индексами: " + sumNegIndex);
}

// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов
// массива.
void Task38()
{
    int size = 5;
    double[] array = new double[size];
    FillArrayDouble(array);
    PrintArrayDouble(array);
    int max = 0;
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[max] < array[i]) max = i;
    }
    for (int i = 0; i < array.Length; i++)
    {
        if(array[min] > array[i]) min = i;
    }
    double result = array[max] - array[min];
    Console.WriteLine($"Разница между макс. и мин. элементом: {array[max]} - {array[min]} = {Math.Round(result, 2)}");
}

Task34();
Task36();
Task38();
