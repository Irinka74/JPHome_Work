// Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵) 2, 4 -> 16


Console.Write( "введите число A: "  );
int A = int.Parse(Console.ReadLine());

Console.Write( "введите число D: "  );
int D = int.Parse(Console.ReadLine());

for(int i = 0; i < 1; i++)


Console.WriteLine($" {Math.Pow(A,D)}");

