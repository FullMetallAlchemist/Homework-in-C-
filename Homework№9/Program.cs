// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void DecreaseNum(int n)
// {
//     Console.Write(n + " ");
//     if (n > 1)
//         DecreaseNum(n - 1);
//     else if (n < 1)
//         DecreaseNum(n + 1);
// }

// Console.WriteLine("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// DecreaseNum(num);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumOfDigits(int m, int n)
// {
//     if(m > n) 
//         return SumOfDigits(m - 1, n) + m;
//     else if(m < n)
//         return SumOfDigits(m, n - 1) + n;
//     else return m;  
// }


// Console.WriteLine("Input a first number: ");
// int numFirst = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a second number: ");
// int numSecond = Convert.ToInt32(Console.ReadLine());
// int numSum = SumOfDigits(numFirst, numSecond);
// Console.WriteLine("The sum of natural elements in the range from M to N is: " + numSum);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
//     else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// Console.WriteLine("Input a first number: ");
// int numFirst = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a second number: ");
// int numSecond = Convert.ToInt32(Console.ReadLine());
// int numAkker = Akkerman(numFirst, numSecond);
// Console.WriteLine("The result of function Akkerman: " + numAkker);
