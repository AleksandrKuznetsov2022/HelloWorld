static void print(string[] Array)
{
    foreach (string item in Array)
        Console.WriteLine($"{item} ");
}
//string[] array = new string[] { "a", "b", "c", "d" };
//print(array);
static void StringToArray(string Text)
{
    string[] array = Text.Split(' ');
    print(array);
}
Console.WriteLine("Введите предложение из нескольких слов, разделенных пробелом");
string Text = Console.ReadLine();

StringToArray(Text);

