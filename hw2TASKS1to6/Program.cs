// ВЫПОЛНИЛА: СЕХИНА ЕЛЕНА
// Задание №1. Программа, возвращающая минимальное из трех чисел
{
    Console.Write("Чтобы узнать минимальное из трех чисел, задайте первое число: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Теперь введите второе число: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("И укажите третье число: ");
    double num3 = Convert.ToDouble(Console.ReadLine());

    if (num1 < num2 && num1 < num3)
    {
        Console.WriteLine();
        Console.WriteLine("Минимальное из трех чисел: " + num1 + ".");
    }
    else if (num2 < num1 && num2 < num3)
    {
        Console.WriteLine();
        Console.WriteLine("Минимальное из трех чисел: " + num2 + ".");
    }
    else if (num3 < num1 && num3 < num2)
    {
        Console.WriteLine();
        Console.WriteLine("Минимальное из трех чисел: " + num3 + ".");
    }
    else
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Упс! Минимального числа нет, так как числа равны между собой: " + num1 + ". Попробуй еще раз!");
    }
}

// Задание №1. Метод, возвращающий минимальное из трех чисел
{
    void minNumber(double num1, double num2, double num3)
    {
        if (num1 < num2 && num1 < num3)
        {
            Console.WriteLine();
            Console.WriteLine("Минимальное из трех чисел: " + num1 + ".");
        }
        else if (num2 < num1 && num2 < num3)
        {
            Console.WriteLine();
            Console.WriteLine("Минимальное из трех чисел: " + num2 + ".");
        }
        else if (num3 < num1 && num3 < num2)
        {
            Console.WriteLine();
            Console.WriteLine("Минимальное из трех чисел: " + num3 + ".");
        }
        else
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Упс! Минимального числа нет, так как числа равны между собой: " + num1 + ". Попробуй еще раз!");
        }
    }

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.Write("Чтобы узнать минимальное из трех чисел, задайте первое число: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Теперь введите второе число: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("И укажите третье число: ");
    double num3 = Convert.ToDouble(Console.ReadLine());

    minNumber(num1, num2, num3);

}

// Задание №2. Программа подсчета количества цифр числа
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine();
    Console.Write("Чтобы посчитать количество цифр числа (число должно быть целым), введите его в поле: ");
    Console.ForegroundColor = ConsoleColor.White;
    int num1 = int.Parse(Console.ReadLine());
    int count = 0;

    while (num1 != 0)
    {
        count++;
        num1 = num1 / 10;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество цифр в числе: {count}.");
}

// Задание №2. Метод подсчета количества цифр числа
{
    int Numbers(int num1)
    {
        int count = 0;

        while (num1 != 0)
        {
            num1 = num1 / 10;
            count++;
        }

        return count;
    }

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Чтобы посчитать количество цифр числа (число должно быть целым), введите его в поле: ");
    Console.ForegroundColor = ConsoleColor.White;
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine($"Количество цифр в числе: {Numbers(num1)}.");

}

// Задание №3. Программа подсчета суммы всех нечетных положительных чисел (ввод чисел, пока не будет введен 0)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("Чтобы подсчитать сумму всех нечетных положительных чисел, вводите целые числа через клавишу Enter (при завершении введите 0):");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Введите первое число: ");
    int num1;
    num1 = int.Parse(Console.ReadLine());
    int count = 0;

    while (num1 != 0)
    {

        if (num1 % 2 != 0 && num1 > 0)
        {
            count = count + num1;

            Console.Write("Введите следующее целое число: ");
            num1 = int.Parse(Console.ReadLine());

        }

        else
        {
            Console.Write("Введите следующее целое число: ");
            num1 = int.Parse(Console.ReadLine());
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма всех нечетных положительных чисел составила: {count}.");
}

// Задание №4. Программа проверки логина и пароля
{
    string userLogin = "root";
    string userPassword = "GeekBrains";
    int Attempts = 3;

    do
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Для доступа в личный кабинет войдите в систему.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Введите логин: ");
        userLogin = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Введите пароль: ");
        userPassword = Console.ReadLine();

        if (userLogin == "root" && userPassword == "GeekBrains")
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Авторизация прошла успешно!");
            Attempts = 0;
        }
        else if (Attempts > 1)
        {
            Attempts--;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Ошибка! Пройдите авторизацию снова. Оставшееся количество попыток: {Attempts}.");
        }
        else
        {
            Attempts--;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Увы! Авторизация не пройдена. Аккаунт заблокирован! Обратитесь в поддержку.");
        }
    }
    while (Attempts != 0);
}

// Задание №4. Метод проверки логина и пароля 
{
    void Checking(string userLogin, string userPassword)
    {
        int Attempts = 3;

        do
        {
            if (userLogin == "root" && userPassword == "GeekBrains")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Авторизация прошла успешно!");
                Attempts = 0;
            }
            else if (Attempts > 1)
            {
                Attempts--;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Ошибка! Пройдите авторизацию снова. Оставшееся количество попыток: {Attempts}.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Введите логин: ");
                userLogin = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Введите пароль: ");
                userPassword = Console.ReadLine();
            }
            else
            {
                Attempts--;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Увы! Авторизация не пройдена. Аккаунт заблокирован! Обратитесь в поддержку.");
            }
        }
        while (Attempts != 0);
    }
    string userLogin;
    string userPassword;

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("Для доступа в личный кабинет войдите в систему.");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Введите логин: ");
    userLogin = Console.ReadLine();
    Console.Write("Введите пароль: ");
    userPassword = Console.ReadLine();

    Checking(userLogin, userPassword);
}

// Задание №5.а) и б) БЕСТАКТНАЯ ПРОГРАММА
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Чтобы расчитать ИМТ (индекс массы тела), введите свою массу (кг): ");
    double mass = Convert.ToDouble(Console.ReadLine());
    Console.Write("Укажите свой рост (м): ");
    double height = Convert.ToDouble(Console.ReadLine());
    double result = mass / (height * height);

    Console.WriteLine();
    Console.WriteLine("Проверьте введенные данные:");
    Console.WriteLine($"Ваш рост: {height} м. Ваша масса: {mass} кг.");

    Console.WriteLine($"Индекс массы тела: {result:F2}");

    switch (result)
    {
        case < 15.99:
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Соответствие между массой человека и его ростом: Выраженный дефицит массы тела!");
            Console.WriteLine("Необходима срочная консультация специалиста!");
            Console.WriteLine($"Вам необходимо набрать {Math.Abs(21.7 * (height * height) - mass):F0} кг.");
            Console.WriteLine();
            break;
        case < 18.50:
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Соответствие между массой человека и его ростом: Недостаточная (дефицит) масса тела.");
            Console.WriteLine("Необходима консультация специалиста.");
            Console.WriteLine($"Вам необходимо набрать {Math.Abs(21.7 * (height * height) - mass):F0} кг.");
            Console.WriteLine();
            break;
        case < 24.99:
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Соответствие между массой человека и его ростом: Норма! :)");
            Console.WriteLine("Так держать!");
            Console.WriteLine($"Вам необходимо набрать {Math.Abs(24.99 * (height * height) - mass):F0} кг.");
            Console.WriteLine();
            break;
        case < 29.99:
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Соответствие между массой человека и его ростом: Избыточная масса тела (предожирение).");
            Console.WriteLine("Необходима консультация специалиста.");
            Console.WriteLine($"Вам необходимо сбросить {Math.Abs(21.7 * (height * height) - mass):F0} кг.");
            Console.WriteLine();
            break;
        case < 34.99:
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Соответствие между массой человека и его ростом: Ожирение первой степени!");
            Console.WriteLine("Необходима консультация специалиста!");
            Console.WriteLine($"Вам необходимо сбросить {Math.Abs(21.7 * (height * height) - mass):F0} кг.");
            Console.WriteLine();
            break;
        case < 39.99:
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Соответствие между массой человека и его ростом: Ожирение второй степени!");
            Console.WriteLine("Необходима консультация специалиста!");
            Console.WriteLine($"Вам необходимо сбросить {Math.Abs(21.7 * (height * height) - mass):F0} кг.");
            Console.WriteLine();
            break;
        case > 40.00:
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Соответствие между массой человека и его ростом: Ожирение третьей степени (морбидное)!");
            Console.WriteLine("Необходима срочная консультация специалиста!");
            Console.WriteLine($"Вам необходимо сбросить {Math.Abs(21.7 * (height * height) - mass):F0} кг.");
            Console.WriteLine();
            break;

        default:
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Наш сервис очень старался, но вы ввели некорректные данные :(");
            Console.WriteLine("Вероятно, вы не человек.");
            Console.WriteLine();
            break;
    }
}

// Задание №6. Написать программу подсчета количества «хороших чисел» (в диапазоне от 1 до 1 000 000 000).
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Внимание!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Запущена программа подсчета количества «хороших чисел» в диапазоне от 1 до 1 000 000 000. Пожалуйста, подождите.");

    int goodNum = 0;
    DateTime start = DateTime.Now;
    for (int a = 1; a != 1000000000; a++)
    {
        int b = 0;
        for (int d = a; d != 0; d = d / 10)
        {
            b = b + (d % 10);
        }
        if (a % b == 0)
        {
            goodNum++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"В диапазоне от 1 до 1 000 000 000 найдено {goodNum} хороших чисел.");
    Console.WriteLine($"Время работы программы: {(DateTime.Now - start)}.");
}
