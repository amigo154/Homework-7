// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void PrintArray(int[,] matr)    
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

void FillArray(int[,] matr)   
{
    for (int i = 0; i < matr.GetLength(0); i++)    
    {
        for (int j = 0; j < matr.GetLength(1); j++)   
        {
            matr[i,j] = new Random().Next(-30,30);
        }
    }
}

Console.Clear();

Console.WriteLine("Введите m - количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n - количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [m, n];
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Введите число a - строку искомого элемента");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b - столбец искомого элемента");
int b = Convert.ToInt32(Console.ReadLine());


if (a < matrix.GetLength(0) && b < matrix.GetLength(1)) 
Console.WriteLine($"заданное число {matrix[a,b]}");
else Console.WriteLine($"Такого элемента нет");