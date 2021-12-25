// ВЫПОЛНИЛА: СЕХИНА ЕЛЕНА

// Задание №7.а) и б). Рекурсивный метод: выводит на экран числа от a до b (a < b) и считает их сумму
class Task7
{
    void RecursiveMethodA(int a, int b)
    {
        Console.Write("{0} ", a);
        if (a < b) RecursiveMethodA(a + 1, b);
    }

    int SumRecursiveMethodB(int a, int b)
    {
        if (b == a)
            return a;
        return SumRecursiveMethodB(a, b - 1) + b;


        Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("Числа от a до b (при условии, что a < b): ");
        RecursiveMethodA(a, b);

        Console.WriteLine();
        SumRecursiveMethodB(a, b);
        Console.WriteLine($"Сумма двух чисел равна: {SumRecursiveMethodB(a, b)}");
    }
}