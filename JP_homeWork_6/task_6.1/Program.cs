// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2   1, -7, 567, 89, 223-> 3

int[] GetArray()
{
    Console.WriteLine("введите количество чисел: ");
    int elementsCount = int.Parse(Console.ReadLine());
    int[] array = new int[elementsCount];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
int count = 0;
string ArrayToString(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]}, ";
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"количество чисел > 0 = {count}");
    return result;
}
Console.WriteLine(ArrayToString(GetArray()));

