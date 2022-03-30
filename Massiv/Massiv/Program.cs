Console.WriteLine("Ведите количество строк матрицы");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы");
int col = int.Parse(Console.ReadLine());
Random r = new Random();
int [,] matrix = new int[row, col];
int summ = 0;
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        matrix[i, j] = r.Next(10);
        Console.Write($"{matrix[i, j]} ");
        summ += matrix[i, j];
    }
    Console.WriteLine();
  
  }
Console.WriteLine($"Сумма всех элеметов равна: {summ}");
Console.ReadKey();

