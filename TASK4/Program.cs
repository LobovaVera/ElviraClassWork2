


//12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
/*34, 5 -> не кратно, остаток 4 
16, 4 -> кратно*/



Console.WriteLine("Enter number one");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number two");
int numberTwo = int.Parse(Console.ReadLine()!);

if ( number > numberTwo)
{
    int count = 0;
    while (number >= numberTwo)
    {
        number = number - numberTwo;
        //count++; 
       

    }
     if (number == 0)
        {
            Console.WriteLine(" Kratno");
        }
    else
    {
        Console.WriteLine($"Ne kratno, ostatok {number}");

    }
    }
else 
{
    Console.WriteLine("ERROR");
}


/*Console.WriteLine("Enter number one");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number two");
int numberTwo = int.Parse(Console.ReadLine()!);

    int newNumber = number%numberTwo;
    if (newNumber == 0)
        {
            Console.WriteLine(" Kratno");
        }
    else
    {
        Console.WriteLine($"Ne kratno, ostatok {newNumber}");

    }*/



   



