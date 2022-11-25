/*
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (numberFirst > numberSecond)
{
    max = numberFirst;
    min = numberSecond;
}
else
{
    max = numberSecond;
    min = numberFirst;
}
Console.Clear();
Console.WriteLine("a = " + numberFirst);
Console.WriteLine("b = " + numberSecond);
Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);
*/



/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberThird = Convert.ToInt32(Console.ReadLine());
int max = numberFirst;
if (max < numberSecond)
{
    max = numberSecond;
}
if (max < numberThird)
{
    max = numberThird;
}
Console.Clear();
Console.WriteLine($"{numberFirst}, {numberSecond}, {numberThird}");
Console.WriteLine("max = " + max);
*/



/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
*/



/*
//Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число больше 0");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (number > 0)
{
    while (count <= number)
    {
        if (count % 2 == 0)
        {
            Console.Write($"{count} ");
        }
        count += 1;
    }
}
else
{
    Console.WriteLine("Неверное число");
}
*/