// ВЫПОЛНИЛА: СЕХИНА ЕЛЕНА

// Задание №2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
// а) Вывести только те слова сообщения, которые содержат не более n букв.
// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
// в) Найти самое длинное слово сообщения.
// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
// д) ***Создать метод, который производит частотный анализ текста.

// В качестве параметра в него передается массив слов и текст,
// в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
// Здесь требуется использовать класс Dictionary.

using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        LogicTask2 LogicTask2 = new();

        Console.WriteLine("\nЗадан некоторый текст: \n" + LogicTask2.SomeText);

        Console.WriteLine("\nВыведем слова текста, содержащие не более 5 букв:");
        LogicTask2.GetWordsByLength(5);

        Console.WriteLine();
        Console.Write("\nУдалим из текста слова, заканчивающиеся на «я»: ");
        LogicTask2.DeleteWordByEndChar('я');

        Console.WriteLine();
        Console.WriteLine("\nСамое длинное слово в тексте: " + LogicTask2.FindMaxLengthWord());


        Console.WriteLine("\nСтрока из самых длинных слов сообщения: \n" + LogicTask2.GetLongWordsString());

        Console.WriteLine("\nЧастотный анализ текста: ");
        string[] arr = { "да", "три", "про", "так", "кипу" };
        LogicTask2.FrequencyAnalysis(arr, LogicTask2.SomeText);

        Console.ReadKey();

    }
}