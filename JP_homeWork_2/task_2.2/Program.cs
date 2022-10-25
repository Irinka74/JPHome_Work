// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.645 -> 5;78 -> третьей цифры нет;32679 -> 6

Console.Write("Введите число: ");

string number = Console.ReadLine();
int a = int.Parse(number);
int k = 10;
if ( a < 100 )
{
Console.WriteLine("третьей цифры нет!"); 
}
else
{ 
    if(a > 999)
    {
       while (true)
       {
         int sep = a / k;
         if (sep > 99 && sep < 1000 )
         {
          break;
         }
       
        else
        {
          k *= 10;
        }
       }
        Console.Write($"третье число {(a / k ) % 10}");
    }
    else
  {
   Console.Write($"третье число {a % 10}");
  }
   
    
    }







