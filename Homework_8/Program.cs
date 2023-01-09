namespace Homework_8;
class Program
{
    static void Main(string[] args)
    {
        //Задача 54: Задайте двумерный массив. Напишите программу, которая
        // упорядочит по убыванию элементы каждой строки двумерного массива.
        void Task54()
        {
            Console.WriteLine("=====  Задача 54  =====");
            int columns = 4;
            int rows = 4;
            int[,] numbers = new int[rows, columns];
            FillArray(numbers);
            PrintArray(numbers);

            for (int i = 0; i < rows; i++)
            {
                for (int count = 0; count < columns - 1; count++)
                {
                    for (int j = 0; j < columns - count - 1; j++)
                    {
                        if (numbers[i, j] > numbers[i, j + 1])
                        {
                            int temp = numbers[i, j];
                            numbers[i, j] = numbers[i, j + 1];
                            numbers[i, j + 1] = temp;
                        }
                    }
                }
            }
            PrintArray(numbers, "Упорядоченный массив:");
            Console.WriteLine();
            Console.WriteLine();
        }

        //Задача 56: Задайте прямоугольный двумерный массив. Напишите
        // программу, которая будет находить строку с наименьшей суммой элементов.
        void Task56()
        {
            Console.WriteLine("=====  Задача 56  =====");
            int rows = 4;
            int columns = 5;
            int[,] numbers = new int[rows, columns];
            FillArray(numbers, 0, 5);
            PrintArray(numbers);

            int sum1 = 0;
            int sum2 = 0;
            int minSumIndex = 0;
            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum1 = sum1 + numbers[minSumIndex, j];
                }
                for (int j = 0; j < columns; j++)
                {
                    sum2 = sum2 + numbers[i, j];
                }
                if (sum1 > sum2) {minSumIndex = i;}
                sum1 = 0;
                sum2 = 0;
            }
            Console.WriteLine("Индекс строки с наименьшей суммой элементов: " + minSumIndex);
            
            Console.WriteLine();
            Console.WriteLine();
        }

        Task54();
        Task56();

    }
    static void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
    {
        maxValue++;
        Random rand = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numbers[i, j] = rand.Next(minValue, maxValue);
            }
        }
    }

    static void PrintArray(int[,] numbers, string message = "Вывод массива: ")
    {
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        Console.WriteLine(message);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
