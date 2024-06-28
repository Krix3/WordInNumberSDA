using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Словарь для хранения соответствий между словами и цифрами
        Dictionary<string, int> numberWords = new Dictionary<string, int>()
        {
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 }
        };

        Console.Write("Введите слово, представляющее цифру от 0 до 9: ");
        string input = Console.ReadLine().ToLower();

        if (numberWords.TryGetValue(input, out int number))
        {
            Console.WriteLine($"Цифра: {number}");
        }
        else
        {
            Console.WriteLine("Неправильный ввод, попробуйте снова.");
        }
    }
}