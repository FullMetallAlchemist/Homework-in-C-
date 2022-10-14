// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Input two integer numbers"); 
Console.Write("Input first number: ");
int number_first = Convert.ToInt32(Console.ReadLine()); //Вводим и присваиваем первое число
Console.Write("Input second number: ");
int number_second = Convert.ToInt32(Console.ReadLine()); //Вводим и присваиваем первое число

if (number_first > number_second) //Сравнение двух чисел
Console.WriteLine($"{number_first} more then {number_second}");
else
Console.WriteLine($"{number_second} more then {number_first}!");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Input three integer numbers");
Console.Write("Input first number: ");
int number_first = Convert.ToInt32(Console.ReadLine()); //Вводим и присваиваем первое число
Console.Write("Input second number: ");
int number_second = Convert.ToInt32(Console.ReadLine()); //Вводим и присваиваем второе число
Console.Write("Input third number: ");
int number_third = Convert.ToInt32(Console.ReadLine()); //Вводим и присваиваем третье число
int max = number_first;

if (number_second > max)                                //Сравниваем числа
 max = number_second;

if (number_third > max)
 max = number_third; 

Console.WriteLine($"The maximum of the entered numbers is {max}"); // Выводим результат
    
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input one number: "); 
int number = Convert.ToInt32(Console.ReadLine()); //Получаем от пользователя число
if(number%2 == 0) // Проверяем число на чётность.
Console.WriteLine($"The entered number {number} is even");
else
Console.WriteLine($"The entered number {number} is odd");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input one integer number: ");    //Запрашиваем число у пользователя
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;                                  //Делаем счётчик
if (number < 2)
Console.WriteLine("There are no even numbers in the list from 1 to N.");
while(number > 1)
{
    if(number%2==0)
    {
        Console.Write(number + " " );
        
    }
    number = number - count;
}
*/

