Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());
int max;
if (numberFirst > numberSecond)
{
    max = numberFirst;
}
else
{
    max = numberSecond;
}
Console.Clear();
Console.WriteLine("a = " + numberFirst);
Console.WriteLine("b = " + numberSecond);
Console.WriteLine("max = " + max);
