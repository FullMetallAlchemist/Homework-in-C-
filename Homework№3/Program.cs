// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (Долполнение Любое число)

// 14212 -> нет

// 12821 -> да

// 23432 -> да

  int Palindrome(int num)
  {
    int sum = 0;
    int rest = 0;
    while (num > 0)
    {
         rest = num % 10;
         num = num / 10;
         sum = sum * 10 + rest;
    }
    return sum;
  }

Console.Write("Input one number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Palindrome(number);
if(number == result)
Console.WriteLine(number +" "+ "YES is a palindrom!");
else
Console.WriteLine(number +" "+ "NO its not a palindrom!");


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double result = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2) );
//     return result;
// }

// Console.Write("Input the x1 coordinate of the first point: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input the y1 coordinate of the first point: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input the z1 coordinate of the first point: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input the x2 coordinate of the first point: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input the y2 coordinate of the first point: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input the z2 coordinate of the first point: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// double result = Math.Round(Distance(x1, y1, z1, x2, y2, z2),2);
// Console.WriteLine("Distance between two points is " + result);

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cube(double num)
// {
//     if (num >= 1)
//     {   int index = 1;
//         while(index <= num)
//         {
//             Console.WriteLine($"The cube of a {index} is {Math.Pow(index,3)}");
//             index++;
//         }
//     }
//     else
//         Console.WriteLine("Error number ");
// }
// Console.Write("Input number greater than or equal 1: ");
// double cubeNum = Convert.ToDouble(Console.ReadLine());

// Cube(cubeNum);
