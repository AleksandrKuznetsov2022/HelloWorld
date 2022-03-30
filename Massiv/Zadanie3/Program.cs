Console.WriteLine("Введите максимальное число");
int max = int.Parse(Console.ReadLine());
int [] data = new int[max];
int count = 0;
for (int i = 0; i < data.Length; i++)
{
    if (count < data.Length)
    {
        data[count] = i;
        count++;
    }
    else
        break;
}
for (int i = 0; i < data.Length; i++)
    Console.Write($" {data[i]}");
int data1 = data[new Random().Next(0, data.Length)];
Console.ReadKey();

while (true)
{
    Console.WriteLine("Введите загаданное число");
    string search = (Console.ReadLine());
    if (string.IsNullOrEmpty(search))
    {
        Console.WriteLine($"Вы не справились, загаданное число {data1}");
        break;
    }
    else
    {
        int search1 = Convert.ToInt32(search);
        if (search1 < data1)
        {
            Console.WriteLine("Введенное число меньше чем загаданное");
        }
        else if (search1 > data1)
        {
            Console.WriteLine("Введенное число больше чем загаданное");
        }
        else
        {
            Console.WriteLine("Поздравляю, число угадано");
            break;
        }
    }
}
Console.ReadKey();
