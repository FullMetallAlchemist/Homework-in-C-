// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] CreatRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(String.Format("{0,3}", array[i, j]));

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void DecreaseElementArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
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
// Console.WriteLine("Array to Lower: ");
// DecreaseElementArray(myArray);
// Show2dArray(myArray);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. P.S.Квадрат является частным случаем прямоугольника.
//  До конца не понял, достаточно ли будет индекса строки. При необходимости, просто добавим 1 к результату :)

// int[,] CreatRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(String.Format("{0,3}", array[i, j]));

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int MinRowAmount(int[,] array)
// {
//     int sum = 0;
//     int sumMin = 0;
//     int minIndex = 0;
//     for (int k = 0; k < array.GetLength(1); k++)                                   
//         sumMin += array[0, k];                                                     
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             sum += array[i, j];
//         if (sum < sumMin)
//         {
//             sumMin = sum;
//             minIndex = i;
//         }
//         sum = 0;
//     }
//     Console.WriteLine();
//     Console.WriteLine(sumMin);
//     return minIndex;
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
// int result = MinRowAmount(myArray);
// Console.WriteLine("A row index with the minimum sum of elements is: " + "" + result);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] CreatRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }


// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(String.Format("{0,4}", array[i, j]));

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] ResaltingMatrix(int[,] array, int[,] arraySecond)
// {
//     int[,] resultArray = new int[arraySecond.GetLength(0), arraySecond.GetLength(1)];
//     for (int l = 0, n = 0; l < resultArray.GetLength(1) && n < arraySecond.GetLength(1); l++, n++)
//         for (int i = 0, k = 0; i < array.GetLength(0); i++, k++)
//             for (int j = 0, m = 0; j < array.GetLength(1) && m < arraySecond.GetLength(0); j++, m++)
//                 resultArray[k, l] = resultArray[k, l] + array[i, j] * arraySecond[m, n];
//     return resultArray;
// }



// Console.Write("Input a number of rows first matrix: ");
// int rowFirstArray = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns first matrix: ");
// int columnFirstArray = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of rows second matrix: ");
// int rowSecondArray = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns second matrix: ");
// int columnSecondArray = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreatRandom2dArray(rowFirstArray, columnFirstArray, 1, 9);
// Console.WriteLine("First Matrix: ");
// Console.WriteLine();
// Show2dArray(myArray);
// Console.WriteLine("Second Matrix: ");
// Console.WriteLine();
// int[,] mySecondArray = CreatRandom2dArray(rowSecondArray, columnSecondArray, 1, 9);
// Show2dArray(mySecondArray);
// Console.WriteLine();
// int[,] resultMatrix = new int[mySecondArray.GetLength(0), mySecondArray.GetLength(1)];
// if (myArray.GetLength(1) != mySecondArray.GetLength(0))
//     Console.WriteLine("It is impossible to perform matrix multiplication!");
// else
// {
//     resultMatrix = ResaltingMatrix(myArray, mySecondArray);
//     Console.WriteLine("Resulting Matrix: ");
//     Console.WriteLine();
//     Show2dArray(resultMatrix);
// }



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 

// int[] CreatUniquedArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     Random numRand = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = numRand.Next(minValue, maxValue);
//         if (i != 0)
//         {
//             for (int j = 0; j < i; j++)
//                 while (array[j] == array[i])
//                 {
//                     array[i] = numRand.Next(minValue, maxValue + 1);
//                     j = 0;
//                 }
//         }
//     }
//     return array;
// }

// int[,,] CreatUnique3dArray(int rows, int columns, int depth, int minValue, int maxValue)
// {
//     int[,,] array = new int[rows, columns, depth];
//     int[] resultArray = CreatUniquedArray(rows * columns * depth, minValue, maxValue);
//     int basicIndex = 0;
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             for (int k = 0; k < depth; k++)
//             {
//                 array[i, j, k] = resultArray[basicIndex];
//                 basicIndex++;
//             }
//     return array;
// }

// void Show3dArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             string output = string.Empty;
//             for (int k = 0; k < array.GetLength(2); k++)
//                 output += (String.Format("{0,10}",$"{array[i, j, k]}({i},{j},{k})"));
//             Console.WriteLine(output);
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of depth: ");
// int k = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int min = 10;
// int max = 99;
// if (m * n * k > 90)
//     Console.WriteLine("An array longer than 90 cannot contain non-repeating two-digit numbers.");
// else
// {
//     int[,,] myArray = CreatUnique3dArray(m, n, k, min, max);
//     Show3dArray(myArray);
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] CreatSpiraldArray(int rows, int columns)
// {

//     int[,] array = new int[rows, columns];
//     int iStart = 0, iLast= 0, jStart = 0, jLast = 0;
//     int i = 0;
//     int j = 0;

//     for (int k = 0; k < array.Length; k++)
//     {
//         array[i, j] = k + 1;
//         if (i == iStart && j < array.GetLength(1) - jLast - 1)
//             j++;
//         else if (j == array.GetLength(1) - jLast - 1 && i < array.GetLength(0) - iLast - 1)
//             i++;
//         else if (i == array.GetLength(0) - iLast- 1 && j > jStart)
//             j--;
//         else
//             i--;

//         if ((i == iStart + 1) && (j == jStart) && (jStart != array.GetLength(1) - jLast- 1)){
//             iStart++;
//             iLast++;
//             jStart++;
//             jLast++;
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(String.Format("{0:00}", array[i, j]));                  // Не получилось использовать 2 Format.

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreatSpiraldArray(m, n);
// Console.WriteLine();
// Show2dArray(myArray);


