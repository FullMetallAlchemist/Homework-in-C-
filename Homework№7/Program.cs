// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreatRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i,j] = Math.Round(new Random().NextDouble(),2) + new Random().Next(minValue, maxValue); 
    
//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(Math.Round(array[i,j],2) + " ");

//         Console.WriteLine();    
//     }
//     Console.WriteLine(); 
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine()); 

// double[,] myArray = CreatRandom2dArray(m, n, min, max);
// Show2dArray(myArray);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreatRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];                                           
//     for(int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue +1);
//     return array;
// }

// void Show2dArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)                                     
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(String.Format("{0,3}", array[i,j]));

//         Console.WriteLine();    
//     }
//     Console.WriteLine(); 
// }

// bool FindElementsArray(int[,] array, int rowNum, int columnNum)
// {
//     return rowNum < array.GetLength(0) && columnNum < array.GetLength(1) && rowNum > -1 && columnNum > -1;
// }

// Console.Write("Input the row index number: ");
// int rowElement = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the column index number: ");
// int columnElement = Convert.ToInt32(Console.ReadLine());  

// int[,] myArray = CreatRandom2dArray(5, 7, 1, 99);
// Show2dArray(myArray);
// Console.WriteLine(FindElementsArray(myArray, rowElement, columnElement));
// if(FindElementsArray(myArray, rowElement, columnElement))
// {
//     Console.WriteLine($"An element in an array with indexes  ({rowElement};{columnElement}) is equal" + " "+ myArray[rowElement,columnElement]);
// }
// else Console.WriteLine("There is no such element in the array");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreatRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];                                           
//     for(int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue +1);
    
//     return array;
// }

// void Show2dArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)                                    
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(String.Format("{0,3}", array[i,j]));

//         Console.WriteLine();    
//     }
//     Console.WriteLine(); 
// }

// void ShowArray(double[] array)                                          
// {
//     Console.Write("Array is: ");

//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.Write(" <]:-o) \n");   
// }

// double[]  ArithmeticMean(int [,] array) 
// {
//     double[] arithmetic = new double[array.GetLength(1)];
//     for(int j = 0; j < array.GetLength(1); j++)
//         for(int i = 0; i < array.GetLength(0); i++)
//             arithmetic[j] += array[i,j];
//     for(int m = 0; m < arithmetic.Length; m++)
//         arithmetic[m] = Math.Round(arithmetic[m] / array.GetLength(0),2);
//     return arithmetic;        
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine()); 

// int[,] myArray = CreatRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// ShowArray(ArithmeticMean(myArray));
