// ВЫПОЛНИЛА: СЕХИНА ЕЛЕНА

/* Задание №1. Дан целочисленный массив из 20 элементов.
Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, 
в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.*/ 

class Program
{
    static void Main(string[] args)
    {
        int PairedWayTask1(int[] arr0, int divisionNumber)
        {
            int sum = 0;

            for (int j = 1; j < arr0.Length; j++)
            {
                if (arr0[j] % divisionNumber == 0 && arr0[j-1] % divisionNumber != 0)
                    sum++;
                    else if (arr0[j-1] % divisionNumber == 0 && arr0[j] % divisionNumber != 0)
                    sum++;
            }
            return sum;
        }
        
        void MethodTask1(int[] arr0, int from, int to)
        {
            Random rnd = new();
            for (int j = 0; j < arr0.Length; j++)
            {
                arr0[j] = rnd.Next(from, to);
            }
        }
        
        int[] arr1 = new int[20];
        MethodTask1(arr1, -10000, 10001);

        Console.WriteLine(PairedWayTask1(arr1, 3));
    }
}