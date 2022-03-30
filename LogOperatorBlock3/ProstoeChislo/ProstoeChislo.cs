Console.WriteLine("Введите целое число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
bool Prost = true;
while (i < N - 1)
{
   i++;
    if (N % i == 0)
    {
        Prost = true;
        break;
    }
    else
    { Prost = false;}
}
if (Prost == true)
{ Console.WriteLine("Число не является простым"); }
else
{ Console.WriteLine("Число является простым"); }
Console.ReadKey();
