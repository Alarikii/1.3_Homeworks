
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void Task10()
{
    Console.WriteLine("Введите трехзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (99 < number & number < 1000)
    {
        Console.WriteLine(number / 10 % 10);
    }
    else
    {
        Console.WriteLine("Введено неправильное число");
    }
}
Task10();
*/

// Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void Task13()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int numberLength(int number)
    {
        int count = 0;
        while (number > 0)
        {
            number = number/10;
            count += 1;
        }
        return count;
    }
    int length = numberLength(number);
    if (length > 2)
    {
        while (length > 3)
        {
            number = number / 10;
            length -= 1;
        }
        int result = number % 10;
        Console.WriteLine("Третья цифра заданного числа: " + result);
    }
    else
    {
        Console.WriteLine("У заданного числа нет третьей цифры");
    }
}
Task13();
*/
// Решение преподавателя
/*
int number = 531351;
while (number > 1000)
{
    number /= 10
    Console.WriteLine(number);
}
Console.WriteLine("Третья цифра числа " + number % 10);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void Task15()
{
    Console.WriteLine("Введите цифру, обозначающую день недели");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 1)
    {
        Console.WriteLine("Понедельник. Не является выходным днем");
    }
    else if (number == 2)
    {
        Console.WriteLine("Вторник. Не является выходным днем");
    }
    else if (number == 3)
    {
        Console.WriteLine("Среда. Не является выходным днем");
    }
    else if (number == 4)
    {
        Console.WriteLine("Четверг. Не является выходным днем");
    }
    else if (number == 5)
    {
        Console.WriteLine("Пятница. Не является выходным днем");
    }
    else if (number == 6)
    {
        Console.WriteLine("Суббота. Является выходным днем");
    }
    else if (number == 7)
    {
        Console.WriteLine("Воскресенье. Является выходным днем");
    }
    else
    {
        Console.WriteLine("Введена неправильная цифра");
    }
}
Task15 ();
*/
//Решение преподавателя
/*
Random rand = new Random();
int day = rand.Next(1,8);
string[] week = {"пн", "вт", "ср", "чт", "пт", "сб", "вс"};
Console.WriteLine(day);
Console.WriteLine(week[day-1]);
if (day > 0 && day < 6) Console.WriteLine("Будний день");
else if (day == 6 || day < 7) Console.WriteLine ("Выходной день");
else Console.WriteLine("Некорректный ввод");
*/