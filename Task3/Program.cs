// Задача принять с консоли введенное число-буквенное выражение и вывести только буквы


string GetLettersFromString(string s) // Создаем строковую функцию (котороя будет проверять на наличие букв и плюсовать их)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine()!;
string result = GetLettersFromString(str);
System.Console.WriteLine(result);