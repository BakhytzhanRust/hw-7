// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // m = 3, n = 4.

// // 0,5 7 -2 -0,2

// // 1 -3,3 8 -9,9

// // 8 7,8 -7,1 9

// int Prompt(string message)
// {
//   Console.Write(message);
//   string ReadInput = Console.ReadLine();
//   int result = int.Parse(ReadInput);
//   return result;
// }

// double[,] CreateandPrintMassive(int m, int n)
// {
//   double[,] mainArray = new double[m, n];
//   Random random = new Random();
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       mainArray[i, j] = Math.Round(random.NextDouble() * random.Next(-10,10),1);
//       Console.Write($"{mainArray[i, j]} ");
//     }
//     Console.WriteLine();
//   }
//   return mainArray;
// }

// int m = Prompt("Write the meaning of m ");
// int n = Prompt("Write the meaning of n ");
// CreateandPrintMassive(m, n);



// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// //  и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:

// // 1 4 7 2

// // 5 9 2 3

// // 8 4 2 4

// // 17 -> такого числа в массиве нет

// int[,] CreateMassive()
// {
//   int m = new Random().Next(1, 10);
//   int n = new Random().Next(1, 10);
//   int[,] array = new int[m, n];
//   Console.WriteLine($"{m} and {n}");
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       array[i, j] = new Random().Next(1, 10);
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
//   return array;
// }

// int DenotetheDesired(string message)
// {
//   Console.Write(message);
//   string ReadInput = Console.ReadLine();
//   int result = int.Parse(ReadInput);
//   return result;
// }

// string FindNumber(int[,] array, int column, int line)
// {
//   string result = "";
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (i + 1 == column && j + 1 == line)
//       {
//         result = result + $"{i + 1}, {j + 1} -> {array[i, j]}";
//       }
//       if (column > array.GetLength(0) + 1 || line > array.GetLength(1) + 1)
//       {
//         result = "there is no such number in the array ";
//       }
//     }
//   }
//   return result;
// }

// string PrintResult(string result)
// {
//   Console.WriteLine(result);
//   return result;
// }
// int column = DenotetheDesired("Write the string you want to check ");
// int line = DenotetheDesired("Write the line(string) you want to check ");
// int[,] array = CreateMassive();
// string result = FindNumber(array, column, line);
// PrintResult(result);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// ЭТУ ЗАДАЧУ Я НЕ ДОРЕШАЛ
// int[,] CreateMassive()
// {
//   int m = new Random().Next(1, 10);
//   int n = new Random().Next(1, 10);
//   int[,] array = new int[m, n];
//   Console.WriteLine($"{m} and {n}");
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       array[i, j] = new Random().Next(1, 10);
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
//   return array;
// }

// void PrintArray(int[,] array)
// {
//   Console.Write("[");
//   for (int i = 0; i < array.Length - 1; i++)
//   {
//     for (int j = 0; j < length; j++)
//     {
      
//     }
//     Console.Write($"{array[i]}, ");
//   }
//   Console.Write($"{array[array.Length - 1]}");
//   Console.WriteLine("]");
// }

// void GetAverage(int[,] matr) 
// {
// double sum = 0;
// double avg = 0; 

// for (int j = 0; j < matr.GetLength(1); j++)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         sum = sum + matr[i, j]; 
//         avg = Math.Round(sum / matr.GetLength(0), 2); 
//     }

//     Console.Write($"{avg}; "); 
//     sum = 0; 
// }
// }

// int[,] array = CreateMassive();
// PrintArray(array);
