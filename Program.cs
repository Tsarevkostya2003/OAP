// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;

int a;
int b;
int znak = 1;
Console.WriteLine("Программа Калькулятор");
Console.WriteLine("1 - сложение");
Console.WriteLine("2 - вычитание");
Console.WriteLine("3 - умножение");
Console.WriteLine("4 - разность");
Console.WriteLine("5 - возведение в степень первого числа");
Console.WriteLine("6 - квадратный корень из числа");
Console.WriteLine("7 - найти процент от первого числа");
Console.WriteLine("8 - найти факториал из числа");
Console.WriteLine("9 - Выйти из программы");

while (znak!=9)
{
    Console.WriteLine("Выберите номер операции");
    znak = Convert.ToInt32(Console.ReadLine());
    if (znak == 1)
    {
        Console.WriteLine("Введите первое слагаемое");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе слагаемое");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a + b);
    }
    if (znak == 2)
    {
        Console.WriteLine("Введите уменьшаемое");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите вычитаемое");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a - b);
    }
    if (znak == 3)
    {
        Console.WriteLine("Введите первый множитель");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второй множитель");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a * b);
    }
    if (znak == 4)  //деление
    {
        Console.WriteLine("Введите делимое");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите делитель");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a / b);
    }
    if (znak == 6) //вычисление квадратного корня
    {
        Console.WriteLine("Введите число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine( Math.Sqrt(a));
    }
    if (znak == 5)
    {
        Console.WriteLine("Введите число, которое нужно возвести в степень");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень");
        b = Convert.ToInt32(Console.ReadLine());
        int result = 1;    
        for (int j=1;j<=b;j++)
        {
            result *= a;
        }
        Console.WriteLine(result);
    }
    if (znak == 7) //вычисление процента
    {
        Console.WriteLine("Введите число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите процент");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a * b / 100);
    }

    if (znak == 8)
    {
        Console.WriteLine("Введите число, от которого нужно найти факториал");
        a = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        for (int j = 1; j <= a; j++)
        {
            result = result * j;
        }
        Console.WriteLine(result);
    }
    if (znak == 9)
    {
        Console.WriteLine("Конец программы");
    }


}
