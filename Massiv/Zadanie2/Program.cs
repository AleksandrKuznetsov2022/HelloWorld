Console.WriteLine("Введите длину последовательности");
int leght = int.Parse(Console.ReadLine());
int min = int.MaxValue;
int [] array = new int[leght];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите положительное или отрицательное число: ");
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] < min)
    {
        min = array[i];
    }
   
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} "); 
}
Console.WriteLine($"Минимальное значение = {min}");
Console.ReadKey();