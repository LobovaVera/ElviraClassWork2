﻿


// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
/*14 -> нет 
46 -> нет 
161 -> да*/


Console.WriteLine(" Введите целое число");
int number = int.Parse(Console.ReadLine()!);

if( number % 7 ==0 && number % 23 ==0)
{
    Console.WriteLine($"число {number} одновременно кратно 7 и 23 ");
}
else
{
     Console.WriteLine($"число {number} одновременно НЕ! кратно 7 и 23 ");
}