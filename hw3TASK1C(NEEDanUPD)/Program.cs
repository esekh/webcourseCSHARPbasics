// Выполнила: СЕХИНА ЕЛЕНА

// Задание №1.в) Добавить диалог с использованием switch демонстрирующий работу класса

struct ComplexStructure
{
public double im;
    public double re;
    // Метод сложения:
    public ComplexStructure Plus(ComplexStructure X)
    {
        ComplexStructure Y;
        Y.im = im + X.im;
        Y.re = re + X.re;
        return Y;
    }
    // Метод вычитания:
    public ComplexStructure Subtraction(ComplexStructure X)
    {
        ComplexStructure Y;
        Y.im = im - X.im;
        Y.re = re - X.re;
        return Y;
    }
    // Метод произведения:
    public ComplexStructure Multiplication(ComplexStructure X)
    {
        ComplexStructure Y = new ComplexStructure();
        Y.re = (this.re * X.re) - (this.im * X.im);
        Y.im = (this.im * X.re) + (this.re * X.im);
        return Y;
    }
    // Метод вывода числа:
    public string ToString()
    {
        if (im < 0) return ($"{re}{im}i");
        else if (im == 0) return ($"{re}");
        else if (re == 0) return ($"{im}i");
        else return ($"{re}+{im}i");
    }
}
    class ComplexClass
    {
        static void Main(string[] args)
        {

            int numRe1, numIm1, numRe2, numIm2, choice;
            string textRe = "вещественную";
            string textIm = "мнимую";
            string textPressEnter = "и нажмите Enter: ";

            do
            {
                Console.Write($"Введите {textRe} часть первого числа {textPressEnter}");
            } while (!int.TryParse(Console.ReadLine(), out numRe1));
            do
            {
                Console.Write($"Введите {textIm} часть первого числа {textPressEnter}");
            } while (!int.TryParse(Console.ReadLine(), out numIm1));
            do
            {
                Console.Write($"Введите {textRe} часть второго числа {textPressEnter}");
            } while (!int.TryParse(Console.ReadLine(), out numRe2));
            do
            {
                Console.Write($"Введите {textIm} часть второго числа {textPressEnter}");
            } while (!int.TryParse(Console.ReadLine(), out numIm2));
            do
            {
                Console.Write("Введите цифру операции, чтобы выполнить требуемое действие (где 1 — сложение; 2 — вычитание; 3 — произведение): ");
            } while (!int.TryParse(Console.ReadLine(), out choice));

            ComplexStructure number1, number2;
            number1.re = numRe1;
            number1.im = numIm1;
            number2.re = numRe2;
            number2.im = numIm2;
            
            switch (choice)
            {
                case 1:
                    Console.Write("Сложение: ");
                    Console.WriteLine(number1.Plus(number2).ToString());
                    break;
                case 2:
                    Console.Write("Вычитание: ");
                    Console.WriteLine(number1.Subtraction(number2).ToString());                    
                    break;
                case 3:
                    Console.Write("Произведение: ");
                    Console.WriteLine(number1.Multiplication(number2).ToString());                    
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }
        }
    }