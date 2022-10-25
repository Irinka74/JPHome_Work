// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.A (3,6,8); B (2,1,-7), -> 15.84


Console.WriteLine( "Введите координаты точки А(x,y,z): ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
int[] array1 = new int[] {x1,y1,z1};

Console.WriteLine( "Введите координаты точки B(x,y,z): ");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
int[] array2 = new int[] {x2,y2,z2};

double result = Math.Sqrt(Math.Pow((array2 [0] - array1 [0]),2) + Math.Pow((array2 [1] - array1 [1]),2) + Math.Pow((array2 [2] - array1 [2]),2));

Console.WriteLine($"Длина {result} ");


