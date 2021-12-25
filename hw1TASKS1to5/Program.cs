// ВЫПОЛНИЛА: СЕХИНА ЕЛЕНА

// Задание №1. Программа «Анкета»
{
    Console.Write("Добро пожаловать! Введите имя: "); // Просим пользователя ввести данные
    string userName = Console.ReadLine(); // Заводим эти данные
    Console.Write("Введите фамилию: ");
    string userSurname = Console.ReadLine();
    Console.Write("Укажите возраст: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите рост (в м): ");
    double height = Convert.ToDouble(Console.ReadLine());
    Console.Write("Укажите вес (в кг): ");
    double weight = Convert.ToDouble(Console.ReadLine());

//Вывод результата через склеивание:
    Console.WriteLine("Проверьте введенные данные: Вас зовут " + userName + " " + userSurname + ", " + age + ", " + height + " м, " + weight + " кг.");
//Форматированный вывод результата:
    Console.WriteLine("Проверьте введенные данные: Вас зовут {0} {1}, {2}, {3} м, {4} кг.", userName, userSurname, age, height, weight);
//Вывод результата через интерполяцию строк (со знаком $):
    Console.WriteLine($"Проверьте введенные данные: Вас зовут {userName} {userSurname}, {age}, {height} м, {weight} кг.");
}

// Задание №2. Расчет индекса массы тела
{
    Console.Write("Чтобы расчитать ИМТ (индекс массы тела), введите показатель m (масса, кг): ");
    double mass = Convert.ToDouble(Console.ReadLine());
    Console.Write("Теперь введите показатель h (рост, м): ");
    double height = Convert.ToDouble(Console.ReadLine());
    double result = mass/(height*height); // Добавляем переменную, которая будет выводить результат расчета формулы по введенным пользователям данным

// По формуле: I=m/(h*h)
    Console.WriteLine("Индекс массы тела: " + mass/(height*height) + ". Для продолжения нажмите Enter.");
    Console.ReadLine();
}

// Задание №3.а) Программа подсчета расстояния между точками
{
    Console.Write("Чтобы расчитать расстояние между точками с координатами (x1;y1), (x2;y1), введите значения координат. x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение координаты y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение координаты x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение координаты y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));

    Console.WriteLine($"Расстояние между точками составит: {result:F2}. Для продолжения нажмите Enter.");
    Console.ReadLine();

// Задание №3.б) Программа подсчета расстояния между точками через метод

    double Method(double x1, double y1, double x2, double y2)
    {
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
    }

    Console.WriteLine($"Расстояние между точками составит: {Method(x1, y1, x2, y2):F2}. Для продолжения нажмите Enter.");
    Console.ReadLine();

// Проверка работоспособности метода с другими числами:
    Console.WriteLine($"Расстояние между точками составит: {Method(2, 3, 5, 6.789):F2}. Для продолжения нажмите Enter.");
    Console.ReadLine();
}

// Задание №4.а) Программа обмена значениями двух переменных с использованием третьей переменной (пункт «а)» — без учета ввода равных друг другу чисел, пункт «б)» с ним)
{
    Console.Write("Чтобы переменные обменялись значениями, для начала введите значение первой переменной: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Теперь введите значение второй переменной: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double num3 = num1;
   { 
    num3=num1;
    num1=num2;
    num2=num3;
   } 

   Console.WriteLine("Готово! Переменные обменялись значениями: первая переменная = " + num1 + ", а вторая переменная = " + num2 + ". Для продолжения нажмите Enter.");
   Console.ReadLine();
}

/* Задание №4.б) Программа обмена значениями двух переменных без использования третьей переменной
КОММЕНТАРИЙ: ЕСТЬ ВАРИАНТ ЧЕРЕЗ «ИСКЛЮЧАЮЩЕЕ ИЛИ» (A = A ^ B, B = B ^ A, A = A ^ B)*/

{
    Console.Write("Чтобы переменные обменялись значениями, для начала введите значение первой переменной: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Теперь введите значение второй переменной: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    {
        if (num1 > num2)
        {
            num1=num1-num2;
            num2=num2+num1;
            num1=num2-num1;

            Console.WriteLine("Готово! Переменные обменялись значениями: первая переменная = " + num1 + ", а вторая переменная = " + num2 + ". Для продолжения нажмите Enter.");
            Console.ReadLine();
        }
        else if (num2 > num1)
        {
            num2=num2-num1;
            num1=num1+num2;
            num2=num1-num2;

            Console.WriteLine("Готово! Переменные обменялись значениями: первая переменная = " + num1 + ", а вторая переменная = " + num2 + ".");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Переменные равны друг другу, поэтому... важен ли обмен?");
        }
    }
}

// Задание №5.а и 5.б) Программа вывода данных в центре экрана
{
    Console.Write("Добро пожаловать! Введите имя: ");
    string userName = Console.ReadLine();
    Console.Write("Введите фамилию: ");
    string userSurname = Console.ReadLine();
    Console.Write("Укажите город проживания: ");
    string userCity = Console.ReadLine();

    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
    /* Положение задаваемого текста будет изменяться с помощью метода SetCursorPosition
    по ширине (WindowWidth, длина выводимой строки) и высоте (WindowHeight, количества строк) окна консоли */
    Console.WriteLine($"{userName} {userSurname}, {userCity}");
}

// 5.в) Программа вывода данных через собственный метод Print
{
    void Print(string MS, int X, int Y)
    // Используем тип void, так как выполняем действие, но ничего не возвращаем 
    {
        Console.SetCursorPosition(X, Y);
        Console.WriteLine($"{MS}");
    }

    Console.Write("Добро пожаловать! Введите имя: ");
    string userName = Console.ReadLine();
    Console.Write("Введите фамилию: ");
    string userSurname = Console.ReadLine();
    Console.Write("Укажите город проживания: ");
    string userCity = Console.ReadLine();

    int X = Console.WindowWidth / 2; // выводим
    int Y = Console.WindowHeight / 2;
    string MS = userName+" "+userSurname+" ,"+userCity;

    Print (MS, X, Y);
}