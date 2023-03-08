// 3адача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк: m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк: n");
int n = Convert.ToInt32(Console.ReadLine());

double[,] Getmatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = new Random().NextDouble()*100;
        }

    }
    return matrix;
}
void Printmatrix(double [,] matr)    
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}


double[,] resultmatrix = Getmatrix(m,n);   

Printmatrix(resultmatrix);






// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1(строчка) 7 (столбец) -> такого числа в массиве нет



// int[,] Getmatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(100);
//         }
//     }
//     return matrix;
// }
// int[,] resultmatrix = Getmatrix(3, 4);

// void Printmatrix(int [,] matr) 
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Printmatrix(resultmatrix);
// Console.WriteLine("Введите позицию строки");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите позицию столбца");
// int cols = Convert.ToInt32(Console.ReadLine());
// if (rows >= 0 && rows < resultmatrix.GetLength(0) && cols >= 0 && cols < resultmatrix.GetLength(1))
// {
//     Console.WriteLine("Значение элемента: " + resultmatrix[rows, cols]);
// }
// else
// {
//     Console.WriteLine("Элемента с такими индексами нет в массиве");
// }




// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



// int[,] Getmatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(100);
//         }
//     }
//     return matrix;
// }
// int[,] resultmatrix = Getmatrix(3, 4);


// void Printmatrix(int [,] matr) 
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Printmatrix(resultmatrix);

// int colsCount=resultmatrix.GetLength(1);
// for (int cols = 0;cols < colsCount; cols++)
// {
//     int sum =0;
//     for (int k = 0; k < resultmatrix.GetLength(0); k++)
//     {
//         sum+=resultmatrix[k,cols];
//     }
//     int mean = sum/resultmatrix.GetLength(0);
//     Console.WriteLine($"Среднее арифметическое элементов столбца {cols}: {mean}");

// }