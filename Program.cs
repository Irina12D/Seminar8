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

/*
int [,] CreateMas2D()
{
    int n = new Random().Next(3,6);
    int m = new Random().Next(3,6);
    int [,] Mas2D = new int[n,m];
    for (int i=0; i<n; i++)
        for(int j=0; j<m; j++)
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
*/


/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
        5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int [,] CreateMas2D()
{
    int n = new Random().Next(5,7);
    int m = new Random().Next(3,5);
    int [,] Mas2D = new int[n,m];
    for (int i=0; i<n; i++)
        for(int j=0; j<m; j++)
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

int NumStrMinSum(int[,] mas)
{
    int num = 0, minS = int.MaxValue;
    int n = mas.GetLength(0);
    int m = mas.GetLength(1);
    for(int i=0; i<n; i++)
    {
        int s = 0;
        for(int j=0; j<m; j++)
            s += mas[i,j];
        if(s < minS)
        {
            minS = s;
            num = i;
        }    
    }
    return num;
}

int [,] Mas2D = CreateMas2D();
PrintMas2D(Mas2D);
Console.WriteLine($"строка с наименьшей суммой элементов - {NumStrMinSum(Mas2D)+1} строка");


