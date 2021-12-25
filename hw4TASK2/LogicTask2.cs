class LogicTask2
{
    public int[] arr2 = new int[20];

    public void Method2(int[] arrOther, int from, int to)
    {
        Random rnd = new();
        for (int i = 0; i < arrOther.Length; i++)
        {
            arrOther[i] = rnd.Next(from, to);
        }
    }
    public void Print()
    {
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write($"{arr2[i]} ");
        }
        Console.WriteLine();
    }

    // пункт б
    public int[] ArrayFromFile(string adress)
    {
        string Text = File.ReadAllText(adress);
        string[] FText = Text.Split(new char[] { ' ', ',', '.', ';' }, StringSplitOptions.RemoveEmptyEntries);

        int[] NewArray = FText.Select(int.Parse).ToArray();

        return NewArray;
    }
}