static void print(string[] Array)
{
    foreach (string item in Array)
        Console.WriteLine($"{item} ");
}
static string ReverseWord(string[] text) // 
{
    Array.Reverse(text);
    string str = string.Join(" ", text);
    return str;
}
string[] array = new string[] { "a", "b", "c", "d" };
print(array);
string NewString = array.ToString();
Console.WriteLine(NewString);