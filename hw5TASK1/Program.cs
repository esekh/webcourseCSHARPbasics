// ВЫПОЛНИЛА: СЕХИНА ЕЛЕНА

// Задание №1. Создать программу, которая будет проверять корректность ввода логина.
// Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
// а) без использования регулярных выражений;
// б) **с использованием регулярных выражений.
using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)

    {
        int AmountOfTries = 3;

        LogicTask1 LogicTask1 = new(); // Создали экземпляр, выделили память для пользования

        do
        {
            Console.Write("Введите логин: ");
            string userLogin = Console.ReadLine();

            if (LogicTask1.CheckLogin(userLogin) && LogicTask1.CheckLoginReg(userLogin))
            {
                Console.WriteLine();
                Console.WriteLine(@"Логин корректен!");
                break;
            }
            else
            {
                AmountOfTries--;
                Console.WriteLine(@$"Неверный ввод логина.
                
                Должны быть соблюдены следующие условия:
                Длина: от 2 до 10 символов;
                Условие №1: буквы латинского алфавита или цифры;
                Условие №2: цифра не может быть первой.

                У Вас осталось {AmountOfTries} {LogicTask1.declensionOfWords(AmountOfTries)}.");
            }

        } while (AmountOfTries > 0);

        Console.WriteLine("\nНажмите Enter для выхода из программы.");
        Console.ReadKey();
    }
}