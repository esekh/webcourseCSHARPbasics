// ВЫПОЛНИЛА: СЕХИНА ЕЛЕНА

/* Задание №2. Реализуйте задачу 1 в виде класса Class;
а) Класс должен содержать метод, который принимает на вход массив и решает задачу 1;
б) Добавьте метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)*Добавьте обработку ситуации отсутствия файла на диске.*/

class Program
{
    static void Main(string[] args)
    {
        LogicTask2 ArrOper = new();

        ArrOper.Method2(ArrOper.arr2, 0, 100);
        ArrOper.Print();

        ArrOper.NoFile("Task.txt");
        // Для проверки с существующим файлом — заменяется строка с методом NoFile:
        // int[] TextFFile = ArrOper.ArrayFromFile("TextForTask2.txt");
        // for (int i = 0; i < TextFFile.Length; i++)
        //{
        //    Console.WriteLine(TextFFile[i]);
        //}
    }
}

