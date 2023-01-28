// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
Console.WriteLine("Средние значения по каждому столбцу равны:");


for (int j = 0; j < matrix.GetLength(1); j++)
{ 
    double average = 0.0;
    double summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
       summ = (summ + matrix[i,j]);
        
    }
    average = summ / matrix.GetLength(1);
    Console.Write($"{Math.Abs(Math.Round(average,1))}   ");
}
