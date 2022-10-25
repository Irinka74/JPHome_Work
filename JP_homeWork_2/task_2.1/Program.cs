// Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа. 456 -> 5 ;782 -> 8; 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");

string number = Console.ReadLine();
int a = int.Parse(number);

if ( a >=100 && a <= 999)
   {
     int result = (((a / 10)) % 10);

     Console.WriteLine("вторая цифра: ");
     Console.WriteLine(result);
   }
else
{

   Console.Write("это не трехзначное число!");   

}