// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки. 
// Указание Использовать рекурсию. Не использовать цикл. 
// Пример “hello” => h l l “World” => W r l d “Hello world!” => H l l w r l d


// using Internal;

// Console.WriteLine("Введите текст");
// string str = Console.ReadLine();

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку с латинскими буквами: ");
        string inputStr = Console.ReadLine();

        string consonants = PrintConsonants(inputStr);
        Console.WriteLine("Согласные буквы в строке: " + consonants);
    }

    static string PrintConsonants(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return "";
        }
        
        char firstChar = str[0];
        if (IsConsonant(firstChar))
        {
            return firstChar + " " + PrintConsonants(str.Substring(1));
        }
        else
        {
            return PrintConsonants(str.Substring(1));
        }
    }

    static bool IsConsonant(char c)
    {
        char lowerCase = char.ToLower(c);
        return lowerCase >= 'a' && lowerCase <= 'z' && "aeiou".IndexOf(lowerCase) == -1;
    }
}