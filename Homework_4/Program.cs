// Возведение числа А в степень В
int AToBPower(int x, int y)
{
    int mult = x;
    while (y > 1)
    {
        mult = mult * x;
        y -= 1;
    }
    return mult;
}

// Преобразование числа формата string в массив
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

// Заполнение массива случайными числами
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
}

// Сортировка элементов массива по модулю(по возрастанию)
void SortArray(int[] array)
{
    int temp;
    for (int count = 0; count < array.Length - 1; count++)
    {
        for (int i = 0; i < array.Length - 1 - count; i++)
        {
            if (Math.Abs(array[i]) > Math.Abs(array[i + 1]))
            {
                temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }
}

// Вывод массива в консоли
void WriteArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine();
}


// Задача 25: Используя определение степени числа,
// напишите цикл, который принимает на вход два
// натуральных числа (A и B) и возводит число A в степень B.
void Task25()
{
    Random rand = new Random();
    int num1 = rand.Next(1, 10);
    Console.WriteLine(num1);
    int num2 = rand.Next(1, 5);
    Console.WriteLine(num2);
    int result = AToBPower(num1, num2);
    Console.WriteLine($"Число {num1} в степени {num2} = {result}");
}

// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
void Task27()
{
    Random rand = new Random();
    int number = rand.Next(1, 10000);
    Console.WriteLine("Введено число: " + number);
    string numberStr = Convert.ToString(number);
    int[] array = StrToArray(numberStr);
    int result = 0;
    for (int i = 0; i < array.Length; i++) result = result + array[i];
    Console.WriteLine("Сумма цифр введенного числа = " + result);
}

// Задача 29: Напишите программу, которая задаёт массив
// из 8 случайных целых чисел и выводит отсортированный
// по модулю массив.
void Task29()
{
    int[] array = new int[8];
    FillArray(array);
    Console.Write("Первоначальный массив: ");
    WriteArray(array);
    SortArray(array);
    Console.Write("Отсортированный по модулю массив: ");
    WriteArray(array);
}

Task25();
Task27();
Task29();
