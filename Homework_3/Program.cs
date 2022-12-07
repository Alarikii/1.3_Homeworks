/* //Преобразование числа формата string в массив
int[] StrToArray(string numString)
{
    int number = Convert.ToInt32(numString);
    int[] array = new int[numString.Length];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        temp = number % 10;
        array[i] = temp;
        number = (number - temp) / 10;
    }
    return array;
}

//Расчет расстояния между точками в 3D
double Diagonal(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}

// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

void Task19()
{
    Console.WriteLine("Введите пятизначное число");
    string number = Console.ReadLine();
    int[] array = StrToArray(number);
    int length = array.Length;
    if (length == 5)
    {
        if (array[0] == array[length - 1])
        {
            if (array[1] == array[length - 2]) Console.WriteLine("Данное число является палиндромом");
            else Console.WriteLine("Число не является палиндромом");
        }
        else Console.WriteLine("Число не является палиндромом");
    }
    else Console.WriteLine("Введено неправильное число");
}
Task19();


// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

void Task21()
{
    Console.WriteLine("Введите координаты точки A по x");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А по y");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А по z");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки A по x");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А по y");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А по z");
    int z2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Координаты точки A ({x1}, {y1}, {z1})");
    Console.WriteLine($"Координаты точки B ({x2}, {y2}, {z2})");
    Console.WriteLine($"Расстояние между A и B = {Math.Round(Diagonal(x1, y1, z1, x2, y2, z2), 3)}");
}
Task21();


// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Task23()
{
    Console.WriteLine("Введите число больше 0");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число" +"\t" + "Куб");
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i + "\t" + (i*i*i));
        }
    }
    else Console.WriteLine("Введено неправильное число");
}
Task23();
 */






