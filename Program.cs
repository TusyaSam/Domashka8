// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 11);
//         }
//         Console.WriteLine();
//     }
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }


// int[,] Metod(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)  // stroki
//     {
//         for (int count = 0; count < array.GetLength(1) - 1; count++) //schetchik na stroke
//         {
//             for (int j = 0; j < array.GetLength(1) - 1; j++) //strolbci
//             {

//                 {
//                     if (array[i, j] < array[i, j + 1])
//                     {
//                         int temp = array[i, j];
//                         array[i, j] = array[i, j + 1];
//                         array[i, j + 1] = temp;
//                     }
//                 }
//             }
//         }
//     }

//     return array;
// }
// System.Console.WriteLine();



// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// Metod(array);
// PrintArray(array);






// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Введите размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, m];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}


void Metod(int[,] array)
{
    int sumMin = 100000;
    for (int i = 0; i < array.GetLength(0); i++)  // stroki
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) //strolbci
        {
            sum = sum + array[i, j];             // nahodim cymmy postrochno
        }
        System.Console.WriteLine($"сумма {i + 1} строки = {sum}");


        if (sum < sumMin)        //nahodim min cymmy
            sumMin = sum;

    }
    System.Console.WriteLine($"сумма MIN= {sumMin}");
}
System.Console.WriteLine();



FillArray(array);
PrintArray(array);
System.Console.WriteLine();
Metod(array);








// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07











// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());



// int [,] Fill2DArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void SortArray(int[,] array)
// // которая поменяет местами первую и последнюю строку массива.
// {
//     for (int j = 0; j < array.GetLength(1); j++) // строки
//     {
//         int temp = array[rows-1, j]; //строки
//         array[rows-1, j] = array[0, j];
//         array[0, j] = temp;
//     }
// }

// int[,] array1 = Fill2DArray(rows, columns);
// Print2DArray(array1);
// System.Console.WriteLine();
// SortArray(array1);
// Print2DArray(array1);

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет
// строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());



// int[,] Fill2DArray()
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t"); // \t - разделение каждого лемента массива
//         }
//         Console.WriteLine();
//     }
// }

// int[,] SortArray(int[,] array)
// // которая поменяет строки на столбцы, но когда они равны.
// {
//     int[,] array1 = new int[rows, columns]; //новый массив, такого же размера
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // стр  оки
//         {
//             array1[i,j]=array[j,i]; //меняем в новом массиве лементы на противоположные
//         }
//     }
//     return array1;
// }
// if (rows==columns) //если кол-во строк и столбцов совпадает, то выводим наш новый массив
// {
//     int[,] massiv =Fill2DArray();
//     Print2DArray(massiv);
//     System.Console.WriteLine();
//     int [,] massiv1=SortArray(massiv);
//     Print2DArray(massiv1);
// }
// else //иначе просим другой массив
// {
//     System.Console.WriteLine("Для данной сортировки массив не той размерности");
// }





// Задача 57: Составить частотный словарь элементов двумерного массива.
//  Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());


// int[,] Fill2DArray()
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 21);
//         }
//     }
//     return array;
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t"); // \t - разделение каждого лемента массива
//         }
//         Console.WriteLine();
//     }
// }
// void Dictionary(int[,] array)
// {
//     int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
//     foreach (int num in numbers)
//     {
//         int count = 0; //счетчик проверки, есть ли i-й лемент в нашем массиве?
//         foreach (int i in array)
//         {
//             if (num == i)
//             {
//                 count++;
//             }
//         }
//         if (count >= 0)
//         {
//             Console.WriteLine($"Значение {num} встречается {count} раз(а)");
//         }
//     }
// }

// int[,] massiv = Fill2DArray();
// Print2DArray(massiv);
// Dictionary(massiv);

// или
// int count=0;
// for (int num=0; num<10;num++)
// {
//     count=0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j]==num)
//             {
//                 count++;
//             }
//         }
//     }
//     if (count!=0) System.Console.WriteLine($"{num} встречается {count} раз");
// }







// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец,
//  на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }


// void FindMin (int[,] array)
// {
//     int imin=0;
//     int jmin=0;
//     int min=array[0,0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (min>array[i,j])
//             {
//                 min=array[i,j];
//                 imin=i;
//                 jmin=j;
//             }
//         }
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i !=imin && j !=jmin) Console.Write(array[i,j]+" ");
//         }
//       System.Console.WriteLine();
//     }
// }

// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// FindMin(array);




// Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника