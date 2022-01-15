// ВЫПОЛНИЛА: СЕХИНА ЕЛЕНА

// Задание №1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
// Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

using System;

public delegate double Func(double a, double x);
class Program
{
    // Метод, принимающий делегат:
    public static void Table(Func F, double a, double x, double b)
    {
        Console.WriteLine("----- A ------- X -------- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
            x += 1;
        }
        Console.WriteLine("-----------------------------------");
    }

    // Метод возвращает значение функции a*x^2:
    public static double MyFunc(double a, double x)
    {
        return a * x * x;
    }

    // Метод возвращает значение функции a*sin(x):
    public static double MySin(double a, double x)
    {
        return a * Math.Sin(x);
    }

    static void Main()
    {
        // Создаем новый делегат и передаем ссылку на него в метод Table:
        Console.WriteLine("Таблица функции a*x^2:");

        // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом:
        Table(new Func(MyFunc), -1.5, -2, 2);

        Console.WriteLine("Таблица функции a*sin(x):");
        Table(new Func(MyFunc), 3, -2, 2);

        Console.ReadKey();
    }
}