// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Task41()
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("======= Задача 41 =======");
    Console.WriteLine("Введите сколько будет введено чисел");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] numbers = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите число " + (i + 1));
        numbers[i] = Convert.ToDouble(Console.ReadLine());
    }
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if(numbers[i] > 0) count++;
    }
    Console.WriteLine();
    Console.WriteLine("Введено чисел больше нуля: " + count);
}

// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
void Task43()
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("======= Задача 43 =======");
    Console.WriteLine("Дано два уравнения прямых: y = k1 * x + b1, y = k2 * x + b2");
    Console.WriteLine("Введите значение коэффициента k1");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение коэффициента b1");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение коэффициента k2");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение коэффициента b2");
    double b2 = Convert.ToDouble(Console.ReadLine());
    double x0 = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y0 = Math.Round((k1 * b2 - k2 * b1) / (k1 - k2), 2);
    Console.WriteLine();
    Console.WriteLine($"Уравнения прямых: y = {k1} * x + {b1} \t y = {k2} * x + {b2}");
    Console.WriteLine($"Точка пересечения прямых: ({x0}, {y0})");
}

Task41();
Task43();


