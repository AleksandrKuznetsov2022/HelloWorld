Console.WriteLine("Введите целое число");
int Number = int.Parse(Console.ReadLine());
if (Number % 2 == 0) 
{ Console.WriteLine($"Число {Number} является четным"); }
else
{ Console.WriteLine($"Число {Number} является не четным"); }
Console.ReadKey();