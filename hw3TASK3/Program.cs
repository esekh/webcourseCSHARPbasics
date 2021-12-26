// Задание №3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
// Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
// Добавить свойства типа int для доступа к числителю и знаменателю;
// Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
// ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
// *** Добавить упрощение дробей.

class Program
{
    static void Main()
    {
        LogicTask3 RACIONAL1 = new LogicTask3();
        RACIONAL1.variableA = 10;
        RACIONAL1.variableB = 15;

        LogicTask3 RACIONAL2 = new LogicTask3();
        RACIONAL2.variableA = 1;
        RACIONAL2.variableB = 5;
        System.Console.WriteLine(RACIONAL1.Decimal);

        LogicTask3 RACIONAL3 = new LogicTask3();
        RACIONAL3 = RACIONAL1.Plus(RACIONAL2);
        System.Console.WriteLine(RACIONAL3.Decimal);
        
        RACIONAL3 = RACIONAL1.Minus(RACIONAL2);
        System.Console.WriteLine(RACIONAL3.Decimal);
        
        RACIONAL3 = RACIONAL1.Multiply(RACIONAL2);
        System.Console.WriteLine(RACIONAL3.Decimal);
        
        RACIONAL3 = RACIONAL1.Division(RACIONAL2);
        System.Console.WriteLine(RACIONAL3.Decimal);

        RACIONAL1.Simplification();
        System.Console.WriteLine();

        System.Console.WriteLine(RACIONAL1.variableA);
        System.Console.WriteLine(RACIONAL1.variableB);
    }
}