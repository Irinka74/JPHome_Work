// Напишите программу, которая принимает на вход пятизначное число и проверяет,
 //является ли оно палиндромом.( 14212 -> нет ; 23432 -> да)

Console.Write("введите пятизначное число: ");
string N = Console.ReadLine();
int [] a = new int[N.Length];

for (int i = 0; i < N.Length/2; i++)
{
  if(N[i] != N[N.Length - i - 1])
   {
  Console.WriteLine("число не палиндром"); break; 
   }
  else
    {
    Console.WriteLine("число палиндром");break;
    }  
}         

 
      
       
        
       





    


