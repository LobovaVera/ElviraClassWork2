//16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет*/

Console.WriteLine("Enter number one");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number two");
int numberTwo = int.Parse(Console.ReadLine()!);


    if(number == numberTwo*numberTwo||numberTwo == number*number)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");

    }
    



