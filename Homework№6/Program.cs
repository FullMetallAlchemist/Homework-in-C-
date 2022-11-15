// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int PositiveEl(int size)
// {
//     int count = 0;
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write("Input a number value: ");
//         if(Convert.ToInt32(Console.ReadLine()) > 0)
//         count = count +1; 
//     }
//     return count;
// }

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int result = PositiveEl(n);
// Console.WriteLine("So the amount of numbers is: " + result);



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.Write("Input a number coefficient k1: ");    // {1,0} {3,-2}                         
// double k1 = Convert.ToInt32(Console.ReadLine());     // {5,2} {9,4}    
// Console.Write("Input a coefficient b1: ");           // {2,-1} {2,1}    
// double b1 = Convert.ToInt32(Console.ReadLine());     // {2,-1} {-3,1}    
// Console.Write("Input a  coefficient k2: ");
// double k2= Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a coefficient b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());

// double[] array = new double[2];
// if (k1 == k2 && b1 != b2) Console.WriteLine("Straight lines have no intersection points");
// else if ((k1 == k2 && b1 == b2)) Console.WriteLine("Straight lines match");
// else
// {
// array[0] = (b2 - b1) / (k1 - k2);
// array[1] = (k1*b2 - k2*b1) / (k1 - k2);
// Console.WriteLine($"Intersection Point is ({array[0]}; {array[1]})");
// }



