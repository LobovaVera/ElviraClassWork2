//случайное от 10 -99, выводим макс число

int number = new Random().Next(10,100);
 Console.WriteLine(number);

 
 int a = number/10;
 int b = number%10;
 if(a>b)
 {
    Console.WriteLine($"max  digit is {a}" );
 }
  if(a<b)
 {
    Console.WriteLine($"max  digit is {b}" );
 }
if (a==b)
{
Console.WriteLine("digits are equal");
}

