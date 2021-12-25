// ВЫПОЛНИЛА: СЕХИНА ЕЛЕНА

// Задание №1.б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.

class Complex
{
    public double im;
    public double re;
    public Complex Subtraction(Complex X)
    {
        Complex Y = new Complex();
        Y.re = this.re - X.re;
        Y.im = this.im - X.im;
        return Y;
    }
    public Complex Multiplication(Complex X)
    {
        Complex Y = new Complex();
        Y.re = (this.re * X.re) - (this.im * X.im);
        Y.im = (this.im * X.re) + (this.re * X.im);
        return Y;
    }
    public string ToString()
    {
        if (im < 0) return ($"{re}{im}i");
        else if (im == 0) return ($"{re}");
        else if (re == 0) return ($"{im}i");
        else return ($"{re}+{im}i");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Complex num1 = new Complex();
        num1.re = 4;
        num1.im = 7;

        Complex num2 = new Complex();
        num2.re = 3;
        num2.im = 5;

        Complex result1 = num1.Subtraction(num2);
        Console.WriteLine(result1.ToString());

        Complex result2 = num1.Multiplication(num2);
        Console.WriteLine(result2.ToString());
    }
}