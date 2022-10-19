// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutNumber(int argNum)  //Метод по выделению второго числа из трехзначного числа
{
   int finalNumber = argNum / 10 % 10;
   return finalNumber;
}

Console.Write("Input one a three-digit integer: ");  
int inputNum = Convert.ToInt32(Console.ReadLine()); // Вводим трёхзначное число
int outputNum = CutNumber(inputNum);                //Прогоняем через метод вводимое нами число 

Console.WriteLine($"The second digit of our number {inputNum} is {outputNum}"); // Выводим на консоль первоначальное и итоговое число
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Example 1 цикл for)

// int CreateArray(int num, int counter)   // Делаем метод, по нахождению третьй цифры в числе
// {
// int result = -1;
//     if (counter < 3)
//     {
//         return result;
//     }
//     else
//     {
//         int cur = 1;
//         for (int i = counter; i > 3; i--)
//         {
//             cur = cur * 10;
//         }

//         result = (num / cur) % 10;
//     }
// return result;
// }
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine()); // Вводим число
// int count = number.ToString().Length;             // Смотрим длину строки
// int сonclusion = CreateArray(number, count);      // Записывание в переменную, выполненный метод 
// if (сonclusion == -1)                             // Условие, число трехзначное и более
// Console.Write($"In a number: {number}, of less than three digits!");  // Вывод на консоль в числе меньше трех цифр
// else
// Console.Write("The third digit in the number is" + " " + сonclusion); // Вывод на консоль в числе три и более символа


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Example 2 цикл while)

// int CreateArray(int num, int counter)   // Делаем метод, по нахождению третьй цифры в числе
// {
// int result = -1;
//     if (counter < 3)
//     {
//         return result;                  // Условие если длина числа меньше 3 символов
//     }
//     else
//     {
//         int cur = 1;
//         int i = 1;

//         while (counter > 3)            // Цикл по нахождению третьей цифры в числе   
//         {
//             cur = cur * 10;
//             counter = counter - i;
//         }

//         result = (num / cur) % 10;
//     }
// return result;
// }
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine()); // Вводим число
// int count = number.ToString().Length;             // Смотрим длину строки
// int сonclusion = CreateArray(number, count);      // Записывание в переменную, выполненный метод 
// if (сonclusion == -1)                             // Условие, число трехзначное и более
// Console.Write($"In a number: {number}, of less than three digits!");  // Вывод на консоль в числе меньше трех цифр
// else
// Console.Write("The third digit in the number is" + " " + сonclusion); // Вывод на консоль в числе три и более символа


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// bool Weekend(int arg)                    
// {
//     if (arg > 5)
//     return true;
//     else
//     return false;
// }

// Console.Write("Input number between 1 and 7: ");
// int day = Convert.ToInt32(Console.ReadLine()); // Вводим число
// bool weekDay = Weekend(day);
// if (weekDay == true)
// Console.WriteLine("Yes, Today is Weekend");
// else
// Console.WriteLine("No, Today you must work");
