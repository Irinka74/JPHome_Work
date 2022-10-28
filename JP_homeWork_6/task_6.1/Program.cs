// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2   1, -7, 567, 89, 223-> 3

using System;
class ReadString
{
    static void Main()
    {
        string str;
        Console.Write("Введите цифры через запятую и нажмите Inter:  ");
        str = Console.ReadLine();
        Console.WriteLine("Вы ввели цифры: " + str);
        Console.ReadKey();
    }
}
/*

Console.Write("Введите числа : ");

Console.Write("Нажмите ESC для остановки ввода!");

 = (Console.ReadKey()).KeyChar;

//int[] array = (Console.ReadLine();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество чисел > 0 = {count}");

/* вариант 1
Console.Write("Введите числа через запятую: ");

Console.Write("Нажмите ESC для остановки ввода!");
int N = int.Parse(Console.ReadLine());

int count = 0;
bool enterNumbers = true;
while (enterNumbers);
{
    N = int.Parse(Console.ReadLine());
    if (N > 0)
    {
        count++;
    }
    
}
Console.WriteLine();
}
/*