/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
    В итоге получается вот такой массив:
        7 4 2 1
        9 5 3 2
        8 4 4 2
*/

int [,] CreateMas2D()
{
    int n = new Random().Next(3,6);
    int m = new Random().Next(3,6);
    int [,] Mas2D = new int[n,m];
    for (int i=0; i<n; i++)
        for(int j=0; j<n; j++)
            Mas2D[i,j] =  new Random().Next(1,10);
    return Mas2D;        
}

void PrintMas2D(int[,] mas)
{
    int n = mas.GetLength(0);
    int m = mas.GetLength(1);
    for(int i=0; i<n; i++)
    {
        for(int j=0; j<m; j++)
            Console.Write(mas[i,j] + " ");
        Console.WriteLine();    
    }
}

int [,] SortMas2D(int[,]mas)
{
    int n = mas.GetLength(0);
    int m = mas.GetLength(1);
    for(int i=0; i<n; i++)
    {
        int[]MasStr = new int[m];
        for(int j=0; j<m; j++)
            MasStr[j] = mas[i,j];
        MasStr = MasStr.OrderByDescending(x => x).ToArray();
        for(int j=0; j<m; j++)
            mas[i,j] = MasStr[j];
    }
    return mas;
}

int [,] Mas2D = CreateMas2D();
PrintMas2D(Mas2D);
Console.WriteLine();
Mas2D = SortMas2D(Mas2D);
PrintMas2D(Mas2D);