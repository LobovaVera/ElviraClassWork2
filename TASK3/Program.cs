// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*456 -> 46
782 -> 72
918 -> 98*/

Console.Clear();

Console.WriteLine("enter a three digit digit");
int number =  int.Parse(Console.ReadLine()!);

int a = number/100*10;
Console.WriteLine(a);
int b = number%100%10;
Console.WriteLine(b);

Console.WriteLine($"new number is {a+b}");

