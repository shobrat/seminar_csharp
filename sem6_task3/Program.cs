// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных.

// Пример “hello” => 2 “world” => 1


Console.WriteLine("Введите строку на латинском в нижнем регистре");
string str = Console.ReadLine()!;

static int GetCountVowels(string str)
{
    int count = 0;
    string vowels = "aiouey"; //согласные
    for (int i = 0; i < str.Length; i++) //проходим посимвольно в вводимой строке
    {
        char currentChar = str[i]; //переменная для перебора символов в массиве
        for (int j = 0; j < vowels.Length; j++) //проходим по согласным буквам 
        {
            if (vowels[j] == currentChar) //сравниваем согласным символы с массивом символов введенного слова
            {
                count++;
            }
        }
    }
    return count;
}

Console.WriteLine(GetCountVowels(str));







// static bool VowelsTest(char[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         char[] wowels = ['a', 'o', 'u', 'e', 'i', 'y'];
//         int sum = 0;
//         foreach (char item in wowels)
//         {
//             if (item == array[i])
//             {
//                 sum += 1;
//             }
//         }
//         Console.WriteLine(sum);
//     }
//     return true;
// }



