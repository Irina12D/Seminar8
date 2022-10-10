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
/*
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
*/

/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
        2 4 | 3 4
        3 2 | 3 3
    Результирующая матрица будет:
        18 20
        15 18
*/
/*


int [,] ProductMatrix(int[,]mas1, int[,] mas2)
{
    int n = mas1.GetLength(0);
    int[,]PrMas = new int[n,n]; 
    for(int i=0; i<n; i++)
    {
        for(int j=0; j<n; j++)
            {
                PrMas[i,j] = 0;
                for(int k=0; k<n; k++)
                    PrMas[i,j] += mas1[i,k]*mas2[k,j];
            }
    }
    return PrMas;
}

int n = new Random().Next(2,5);
int [,] MasA = CreateMas2D(n);
int [,] MasB = CreateMas2D(n);
Console.WriteLine("Матрица А:");
PrintMas2D(MasA);
Console.WriteLine();
Console.WriteLine("Матрица B:");
PrintMas2D(MasB);
Console.WriteLine();
Console.WriteLine("Матрица C = A * B:");
int [,] MasC = ProductMatrix(MasA, MasB);
PrintMas2D(MasC);
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2
        66(0,0,0) 25(0,1,0)
        34(1,0,0) 41(1,1,0)
        27(0,0,1) 90(0,1,1)
        26(1,0,1) 55(1,1,1)
*/


int [ , , ] CreateMas3D()
{
    int x = new Random().Next(3,5);
    int y = new Random().Next(2,5);
    int z = new Random().Next(2,4);
    int [ , ,] Mas3D = new int[x,y,z];
    List<int> list = new List<int>();
    for (int i=0; i<x; i++)
        for(int j=0; j<y; j++)
            for(int k=0; k<z; k++)
                {
                    int Num = new Random().Next(10,100);
                    while(list.Contains(Num))
                    {
                        Num = new Random().Next(10,100);
                    }
                    list.Add(Num);
                    Mas3D[i,j,k] = Num;
                }
    return Mas3D;        
}

void PrintMas3D(int[,,] mas)
{
    int n = mas.GetLength(0);
    int m = mas.GetLength(1);
    int t  = mas.GetLength(2);
    for (int i = 0; i < n; i++) 
    {
        for (int j = 0; j < m; j++) 
        {
            for (int k = 0; k < t; k++)
                Console.Write($"{mas[i,j,k]} ({i},{j},{k})  " );
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int [,, ] Mas3D = CreateMas3D();
PrintMas3D(Mas3D);

