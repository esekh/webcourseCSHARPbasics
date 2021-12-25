// ВЫПОЛНИЛА: СЕХИНА ЕЛЕНА

// Задание №1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.

struct ComplexStructureA
{
    public double im;
    public double re;
    // Метод сложения:
    public ComplexStructureA Plus(ComplexStructureA X)
    {
        ComplexStructureA Y;
        Y.im = im + X.im;
        Y.re = re + X.re;
        return Y;
    }
    // Метод вычитания:
    public ComplexStructureA Subtraction(ComplexStructureA X)
    {
        ComplexStructureA Y;
        Y.im = im - X.im;
        Y.re = re - X.re;
        return Y;
    }
    // Метод вывода числа:
    public string ToString()
    {
        if (im < 0) return ($"{re}{im}i");
        else return ($"{re}+{im}i");
    }
}
class Task1A
{
    static void Main(string[] args)
    {
        ComplexStructureA num1, num2;
        num1.im = 2;
        num1.re = 3;

        num2.im = 7;
        num2.re = 9;

        Console.Write("Сложение комплексных чисел: ");
        ComplexStructureA result1 = num1.Plus(num2);
        Console.WriteLine(result1.ToString());

        Console.Write("Вычитание комплексных чисел: ");
        ComplexStructureA result2 = num1.Subtraction(num2);
        Console.WriteLine(result2.ToString());
    }
}
