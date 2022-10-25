// //возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵) 2, 4 -> 16
// второй вариант решения


Console.Write( "введите число A: "  );
int A = int.Parse(Console.ReadLine());

Console.Write( "введите число D: "  );
int D = int.Parse(Console.ReadLine());

int n = A;
for(int i = 1; i < D; i++)
{
n = n * A;
}

Console.WriteLine($"Число A в степени D = {n}");