namespace Homework_9;
class Program
{
    static void Main(string[] args)
    {
        // Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который
        // выведет все натуральные числа кратные 3-ём в промежутке от M до N.
        void Task64()
        {
            Console.WriteLine("=====  Задача 64  =====");
            Console.WriteLine("Введите нижнюю границу интервала (натуральное число)");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу интервала (натуральное число)");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (0 <= num1 && 0 <= num2)
            {
                Console.WriteLine($"Числа кратные 3 в промежутке [{num1}, {num2}]: ");
                DigitsRowOf3(num1, num2);
            }
            else Console.WriteLine("Введено не натуральное число");

            Console.WriteLine();
            Console.WriteLine();
        }

        // Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который
        // найдёт сумму натуральных элементов в промежутке от M до N.
        void Task66()
        {
            Console.WriteLine("=====  Задача 66  =====");
            Console.WriteLine("Введите нижнюю границу интервала (натуральное число)");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу интервала (натуральное число)");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (0 <= num1 && 0 <= num2)
            {
                Console.WriteLine($"Сумма чисел в промежутке [{num1}, {num2}]: {SumRow(num1, num2)}");

            }
            else Console.WriteLine("Введено не натуральное число");

            Console.WriteLine();
            Console.WriteLine();
        }

        // Задача 68: Напишите программу вычисления функции Аккермана с помощью
        // рекурсии. Даны два неотрицательных числа m и n.
        void Task68()
        {
            Console.WriteLine("=====  Задача 68  =====");
            Console.WriteLine("Введите первое число натуральное число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе натуральное число)");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (0 <= num1 && 0 <= num2)
            {
                Console.WriteLine($"Функция Аккермана A({num1}, {num2}): {Akkerman(num1, num2)}");

            }
            else Console.WriteLine("Введено не натуральное число");

            Console.WriteLine();
            Console.WriteLine();
        }

        Task64();
        Task66();
        Task68();

    }
    static void DigitsRowOf3(int num1, int num2)
    {
        if (num1 > num2) return;
        if (num1 % 3 == 0)
        {
            Console.Write(num1 + "  ");
        }
        num1++;
        DigitsRowOf3(num1, num2);
    }

    static int SumRow(int num1, int num2, int sum = 0)
    {
        if (num1 > num2) return sum;
        sum += num1;
        num1++;
        return SumRow(num1, num2, sum);
    }

    static int Akkerman(int m, int n)
    {
        if(m == 0) return(n+1);
        else if (n == 0) {return Akkerman(m-1, 1);}
        else {return Akkerman(m-1, Akkerman(m, n-1));}
    }
}
