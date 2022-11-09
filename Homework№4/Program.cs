// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Exponentiation(int num1, int num2)
// {
//     int degree = num1;
//     if(num2 == 0) return degree = 1; 
//     for (int i = 1; i < num2; i++ )
//     {
//        degree = num1 * degree;  
//     }
//     return degree;
// }

// Console.WriteLine("Input number A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input degree B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The result of exponentiation is  {Exponentiation(a, b)}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int FindSum(int number)
// {
//     int sum = 0;
//     int remain = number;
//     if (number == 0) return sum = 0;

//         while (remain !=0)
//     {
//         remain = number % 10;
//         sum = sum + remain;
//         number = number /10;
//     }   
//     return sum;

// }
// Console.WriteLine("Input number: ");
// int result = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The sum of digits in a number {result} is {FindSum(result)}");


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// int[] CreateСustomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         Console.Write("Input a number value: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("Array is: ");

//     for(int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");
//     Console.Write(" <]:-o) \n");    
// }

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateСustomArray(n);
// ShowArray(myArray);