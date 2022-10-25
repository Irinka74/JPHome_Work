// // Напишите программу, которая принимает на вход пятизначное число и проверяет,
 //является ли оно палиндромом.( 14212 -> нет ; 23432 -> да)


 Console.Write("введите пятизначное число: ");
{
    string N = Console.ReadLine();
    bool a = true;
 
    for (int i = 0; i < N.Length / 2; i++)
        if (N[i] != N[N.Length - i - 1])
            a = false;
 
    if (a)
        Console.WriteLine($"Ваше число: {N} - палиндром!");
    else Console.WriteLine($"Ваше число: {N} - НЕ палиндром!");
 
    return;
}