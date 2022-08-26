// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.Write("Введите m, чтобы задать размер будущего массива (m х n): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n, чтобы задать размер будущего массива (m х n): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

Create2DArray(array);

WriteArray(array);

Console.WriteLine();

void Create2DArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}

