// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


 Console.Write("Введите N:");
int N = int.Parse(Console.ReadLine());
 
 void FindNumber(int N)
{
    if (N > 0)
    {
        Console.Write("{0} ", N);
        FindNumber(N - 1);
    }
}
FindNumber(N);
