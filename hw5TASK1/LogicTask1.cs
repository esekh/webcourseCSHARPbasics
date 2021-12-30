using System;
using System.Text.RegularExpressions;

class LogicTask1
{
    public bool CheckLogin(string userLogin)
    {
        int length = userLogin.Length;
        if (length >= 2 && length <= 10)
        {
            bool check = true;
            char letter = userLogin[0];
            if (Char.IsDigit(letter))
                return false;
            for (int i = 1; i < length; i++)
            {
                letter = userLogin[i];
                if (!(Char.IsLetterOrDigit(letter)))
                {
                    check = false;
                    break;
                }
            }
            if (check)
                return true;
        }
        return false;
    }

    private bool IsLatinLetter(char letter)
    {
        int B = letter;
        if ((B >= 65 && B <= 90) || (B >= 97 && B <= 122))
            // Заглавные латинские буквы: 65 — 90. Строчные латинские буквы: 97 — 122
            return true;
        else
            return false;
    }
    public bool CheckLoginReg(string userLogin) // Метод проверки через регулярные выражения
    {
        char letter = userLogin[0];
        if (Char.IsDigit(letter))
            return false;
        if (!Regex.IsMatch(userLogin, @"^[a-zA-Z0-9]+${2,10}")) // [a-zA-Z0-9]: совпадение с одиночной буквой (от a z или A до Z ) или цифровым символом
            return false;
        return true;
    }

    // Создание метода для склонения 
    public string declensionOfWords(int A)
    {
        string S = "";
        if (A % 10 == 1 && A != 11) S += "попытка";
        else

    if ((A >= 2 && A <= 4) || (A >= 22 && A <= 24) || (A >= 32 && A <= 34) || (A > 41 && A < 45)) S += "попытки";
        else

        if ((A == 0) || (A == 11) || (A >= 5 && A <= 20) || (A >= 25 && A <= 30) || (A >= 35 && A < 41) || (A > 44 && A < 51)) S += "попыток";
        return S;
    }

}