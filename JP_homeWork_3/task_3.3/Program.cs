// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N =  ");
int n = int.Parse(Console.ReadLine());
double[] array = new double[n];
for (int i = 0; i < n; i++)

array[i] = Math.Pow(i + 1,3);

foreach (double i in array)
Console.WriteLine(i);
