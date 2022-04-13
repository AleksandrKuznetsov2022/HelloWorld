static string ReversWord(string splitPhrase)
{
    string[] array = SplitToWords(splitPhrase);
    string ResaltString = string.Empty;
    for (int i = array.Length - 1; i >= 0; i--)
    {
        ResaltString += " " + array[i];
    }
    Console.WriteLine(ResaltString);
    return ResaltString;
}
static string[] SplitToWords(string inputPhrase)
{
    string [] arrayWords = inputPhrase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return arrayWords;
}
Console.WriteLine("Введите слова разделенные пробелом");
string inputPhrase = Console.ReadLine();
string result = ReversWord(inputPhrase);
Console.WriteLine(result);