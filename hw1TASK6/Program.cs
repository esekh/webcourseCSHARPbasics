// ВЫПОЛНИЛА: СЕХИНА ЕЛЕНА
// 6. Создание класса с методом

    Console.Write("Добро пожаловать! Введите имя: ");
    string userName = Console.ReadLine();
    Console.Write("Введите фамилию: ");
    string userSurname = Console.ReadLine();
    Console.Write("Укажите город проживания: ");
    string userCity = Console.ReadLine();
    int X = Console.WindowWidth / 2;
    int Y = Console.WindowHeight / 2;
    string MS = userName+" "+userSurname+" ,"+userCity;
    NewMethods.Pause();
    // Будет ждать вывода данных, пока пользователь не нажмет на кнопкку
    NewMethods.Print(MS, X, Y);

class NewMethods
{
    public static void Pause()
        {
             Console.ReadKey();
             // ReadKey — ожидание нажатия любой клавиши пользователем
        }
    public static void Print(string MS, int X, int Y)
    // public — чтобы NewMethods работали по всему документу
        {
             Console.SetCursorPosition(X, Y);
             Console.WriteLine($"{MS}");
        }
}

