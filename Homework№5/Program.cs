// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size, int minValue, int maxValue)         // Создание массива типа int (метод переиспользуется в дз)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue +1);

//         return array;
// }

// void ShowArray(int[] array)                                          // Вывод массива на консоль  (метод переиспользуется в дз)
// {
//     Console.Write("Array is: ");

//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.Write(" <]:-o) \n");   
// }

// int CountEvenNum(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++ )
//         if(array[i] % 2 == 0)
//         count = count +1;
//     return count;    
// }

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int min = 100;
// int max = 999;

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// int result = CountEvenNum(myArray);
// Console.WriteLine($"The number of even numbers in the array is {result}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int SumOddInt(int[] array)
// {                   
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//         sum = sum + array[i];
//     return sum;
// }

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// int sumOddNum = SumOddInt(myArray);
// Console.WriteLine($"The sum of the elements standing in odd positions is {sumOddNum}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.


// Double[] CreateRandomArray(int size, int minValue, int maxValue) 
// {
//     double[] array = new double[size];
//     for(int i = 0; i < size; i++)
//         array[i] = Math.Round(new Random().NextDouble(),2) + new Random().Next(minValue, maxValue);                                       
//         return array;
// }

// void ShowArray(double[] array)
// {
//     Console.Write("Array is: ");
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(Math.Round(array[i],2) + " ");
//     Console.Write(" <]:-o) \n");   
// }

// double DiffNum(double[] array)
// {   
//     double diff = 0;
//     double max = array[0];
//     double min = array[1];
//     for(int i = 0; i < array.Length; i++)
//     {if (array[i] > max)
//         max = array[i];
//     if (array[i] < min)
//         min = array[i];
//     }
//     diff = max - min;
//     return diff;
// }

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// double diffrence = Math.Round(DiffNum(myArray),2);
// Console.WriteLine(diffrence);