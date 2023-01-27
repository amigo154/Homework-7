// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray(double[,] matr)   
{
    for (int i = 0; i < matr.GetLength(0); i++)    
    {
        for (int j = 0; j < matr.GetLength(1); j++)   
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)   
{
    for (int i = 0; i < matr.GetLength(0); i++)    
    {
        for (int j = 0; j < matr.GetLength(1); j++)   
        {
            matr[i,j] = new Random().Next(-100,100)/10.0;
        }
    }
}
Console.Clear();

Console.WriteLine("Введите m - количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n - количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [m, n];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);