using System;
using System.Text;
using System.Collections.Generic;

class LogicTask2
{
    public string SomeText = @"В четверг четвертого числа, в четыре с четвертью часа, лигурийский регулировщик регулировал в Лигурии,
но тридцать три корабля лавировали, лавировали, да так и не вылавировали,
и потом протокол про протокол протоколом запротоколировал, как интервьюером интервьюируемый
лигурийский регулировщик речисто, да не чисто рапортовал, да так зарапортовался про размокропогодившуюся погоду,
что дабы инцидент не стал претендентом на судебный прецедент, лигурийский регулировщик акклиматизировался в неконституционном Константинополе,
где хохлатые хохотушки хохотом хохотали и кричали турке, который начерно обкурен трубкой:
«Не кури, турка, трубку, купи лучше кипу пик, лучше пик кипу купи,
а то придет бомбардир из Брандебурга — бомбами забомбардирует за то, что некто чернорылый у него полдвора рылом изрыл, вырыл и подрыл!»";

    public void GetWordsByLength(int length) // Метод выводит слова сообщения, которые содержат не более n букв
    {
        string[] words = SomeText.Split(new Char[] { '«', '»', ' ', ',', '.', '—', '\n', '\t' });

        foreach (string word in words)
        {
            if (word == "")
                continue;
            if (word.Length <= length)
                Console.Write(word + " ");
        }
    }

    public void DeleteWordByEndChar(char ch) // Метод удаляет из сообщения все слова, которые заканчиваются на заданный символ
    {
        string[] words = SomeText.Split(new Char[] { ' ', ',', '.', '—', '\n', '\t' });
        foreach (string word in words)
        {
            if (word == "")
                continue;
            if (word[word.Length - 1] == ch)
            {
                Console.Write(word + " ");
                SomeText.Replace(word, "");
            }
        }
    }

    public string FindMaxLengthWord() // Метод находит самое длинное слово сообщения
    {
        string[] words = SomeText.Split(new Char[] { ' ', ',', '.', '—', '\n', '\t' });
        string maxWord = words[0];
        int max = words[0].Length;

        foreach (string word in words)
        {
            if (word.Length > max)
            {
                max = word.Length;
                maxWord = word;
            }
        }
        return maxWord;
    }

    public StringBuilder GetLongWordsString() // Метод формирует строку StringBuilder из самых длинных слов сообщения
    {
        string[] words = SomeText.Split(new Char[] { ' ', ',', '.', '—', '\n', '\t' });
        StringBuilder result = new StringBuilder();
        int max = FindMaxLengthWord().Length;
        foreach (string word in words)
        {
            if (word.Length == max)
            {
                result.Append(word.ToLower() + " ");
            }
        }
        return result;
    }

    public void FrequencyAnalysis(string[] words, string text) // Метод производит частотный анализ текста 
    {
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        string[] textWords = text.Split(new Char[] { ' ', ',', '.', '—', '\n', '\t' });
        foreach (string word in words)
        {
            foreach (string wordInText in textWords)
            {
                if (word == "")
                    continue;
                if (wordInText == word)
                {
                    if (word == "")
                        continue;
                    if (wordFrequency.ContainsKey(word))
                        wordFrequency[word] += 1;
                    else
                        wordFrequency.Add(word, 1);
                }
            }
        }
        ICollection<string> keys = wordFrequency.Keys;

        String result = String.Format("{0,-10} {1,-10}\n\n", "Слово", "Частота появления");

        foreach (string key in keys)
            result += String.Format("{0,-10} {1,-10:N0}\n",
            key, wordFrequency[key]);
        Console.WriteLine($"\n{result}");
    }
}