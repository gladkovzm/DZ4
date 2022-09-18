//\\ Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число В: ");
// int B = Convert.ToInt32(Console.ReadLine());
// if (B == 0)
// {
//     Console.Write($"Число {A} в степени {B} = 1");
// }
// else
// {
//     int work = A;
//     for (int i = 2; i <= B; i++)
//     {
//         A *= work;
//     }
//     Console.WriteLine($"Число {work} в степени {B} = {A}");
// }


//\\ Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sum(int num)
// {
//     int sum=0;
//     while (num > 0)
//     {
//         sum+=num%10;
//         num/=10;
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Напишите число, что бы вывести сумму его чисел: ");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма чисел = {Sum(A)}");

  

//\\ Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Clear();
// Console.WriteLine("Введите количество элементов  массива");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите начальное число для случайного диапазона чисел");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите конечное число для случайного диапазона чисел");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] arrayz = new int[num]; 
// Random rand = new Random(); 
// for (int i = 0; i < arrayz.Length; i++)
// {
//     arrayz[i] = rand.Next(min, max + 1);
//     Console.Write($"{arrayz[i]}, ");
// }


//\\ Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.Clear();
// int[] arrayz = new int[3]; 
// Random rand = new Random(); 
// int k = 0;
// for (int i = 0; i < arrayz.Length; i++)
// {
//     arrayz[i] = rand.Next(100, 1000);
//     Console.Write($"{arrayz[i]}, ");
//     if (arrayz[i] % 2 == 0)
//     {
//         k++;                   
//     }
// }
// Console.Write("Количество четных чисел-> " +k );


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Clear();
// Console.WriteLine("Введите количество элементов  массива");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] arrayz = new int[num]; 
// Random rand = new Random(); 
// int sum = 0;
// for (int i = 0; i < arrayz.Length; i++)
// {
//     arrayz[i] = rand.Next(-99, 100);
//     Console.Write($"{arrayz[i]}, ");
//     if (i % 2 != 0)
//     {
//         sum += arrayz[i];                   
//     }
// }
// Console.WriteLine("Сумма нечетных позиций массива-> " +sum );


//\\ Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Console.Clear();
// Console.WriteLine("Введите количество элементов  массива, для нахождения разницы между максимальным и минимальным элементом");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] arrayz = new int[num]; 
// Random rand = new Random(); 
// for (int i = 0; i < arrayz.Length; i++)
// {
//     arrayz[i] = rand.Next(-99, 100);
// }
// Console.WriteLine($"[{String.Join(", ", arrayz)}]");
// int min = arrayz[0];
// int max = arrayz[0];
// for (int i = 0; i < arrayz.Length; i++)
// {
//     if (arrayz[i] > max)
//     {
//         max = arrayz[i];                
//     }   
//     if (arrayz[i] < min)
//     {
//         min = arrayz[i];
//     }
// }
//  Console.WriteLine($"Минимальное;  {min}  Максимальное; {max}");
//  Console.WriteLine($"Разница между максимальным и минимальным элементом; {max-min}");




/////////////// DZ6

//\\ Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Clear();
// Console.Write("Введите элементы через пробел, чтобы узнать количество положительных чисел: ");
// int[] arrayz = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
// int count = 0;
// for (int i = 0; i < arrayz.Length; i++)
// {
//     if (arrayz[i] > 0)
//     {
//         count++;
//     }
// } 
// Console.WriteLine($"Количество положительный элементов: {count}");
    

//\\ Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Clear();
// Console.WriteLine("Введите значения для заданных уравнений y = k1 * x + b1, y = k2 * x + b2 для нахождения пересечения двух прямых");
// Console.Write("Введите k1: ");
// int k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// int b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// int k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// int b2 = Convert.ToDouble(Console.ReadLine()); 
// if (k1 == k2 && b1 == b2)
// {
//     Console.WriteLine("Совпадение прямых");
// }
// else if (k1 == k2)
// {
//     Console.WriteLine("Нет точек пересечений ");
// }
// else 
// {
//     int x = (b2 - b1) / (k1 - k2);
//     int y = k1 * x + b1;
//     Console.WriteLine($"Пересечение в точке: ({x:f2}; {y:f2})");
// }


/////////////// DZ6

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.Clear();
// System.Console.WriteLine("Введите количество строк: ");
// int str = int.Parse(Console.ReadLine() ?? "0");
// System.Console.WriteLine("Введите количество столбцов: ");
// int col = int.Parse(Console.ReadLine() ?? "0");
// double[,] matrix = new double[str, col];
// NewRandomMatrix(matrix);

// void NewRandomMatrix (double[,] matrix)
// {
//     Random rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.NextDouble() * 200 - 100;
//             Console.Write("{0,9:F1}", matrix[i, j]);
//         }
//         Console.WriteLine();
//     }
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Clear();
// double[,] matrix = new double[5, 5];
// NewRandomMatrix(matrix);
// Console.Write("Введите строку массива: ");
// int str = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите столбец массива: ");
// int col = int.Parse(Console.ReadLine() ?? "0");
// if (str<=matrix.GetLength(0) && col<=matrix.GetLength(1))
// {
//     Console.WriteLine($"Значение элемента: {matrix[str-1,col-1]:f1}");
// }
// else
// {
//     Console.WriteLine("Нет такого элемента! ");
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Clear();
// int[,] matrix = new int[5,5];
// Random rand = new Random();
// double num = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = rand.Next(1, 9);
//         Console.Write($"{matrix[i, j]}\t");
//     }
//     Console.WriteLine();
//     num++;
// }
// Console.Write("Среднее арифметическое каждого столбца: ");
// int sum = 0;
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum=sum+matrix[i,j];
//     }
//     Console.Write("{0,9:F1};", sum/num );
//     sum = 0;
// }


////////////////////////DZ7

//\\ Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.Clear();
// Console.WriteLine("Неотсортированный массив: ");
// int[,] array = new int[4, 4];
// CreateArray(array);
// WriteArray(array);

// Console.WriteLine("Отсортированный массив: ");
// OrderArrayLines(array);
// WriteArray(array);

// void OrderArrayLines(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(10);
//     }
//   }
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }


//\\ Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Clear();
// int[,] array = new int[4, 4];
// CreateArray(array);
// WriteArray(array);
// int minsum = 0;
// int sum = SumElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempsum = SumElements(array, i);
//   if (sum > tempsum)
//   {
//     sum = tempsum;
//     minsum = i;
//   }
// }

// Console.WriteLine($"\n{minsum+1} - строкa с наименьшей суммой элементов = {sum} ");


// int SumElements(int[,] array, int i)
// {
//   int sum = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sum += array[i,j];
//   }
//   return sum;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(1, 10);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }


//\\ Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
int[,] firstMartrix = new int[2, 2];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[2, 2];
CreateArray(secondMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[2,2];
MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

//\\ Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//\\ Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07