
static string SplitString(string Text)
{
    string[] array = Text.Split(' ');
    string NewString = ReverseWord(array);
    return NewString;
}
static string ReverseWord(string[] Text)
{
    Array.Reverse(Text);
    string str = string.Join(" ", Text);
    return str;
}
Console.WriteLine("Введите предложение из нескольких слов, разделенных пробелом");
string Sentence = Console.ReadLine();
Sentence = SplitString(Sentence);
Console.WriteLine(Sentence);
Console.ReadKey();