// Задача 38: Задайте массив вещественных чисел. random.Next(1,10); 
//Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76


Console.Write("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] GetArray()
{
     double[] array = new double[n];
    Random random = new Random();
   
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(random.Next(-100, 100)/10.0);
    }

    return array;
}

double GetMinElementsArray(double[] array)
{
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double GetMaxElementsArray(double[] array)
{
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < n; i++)
    {
        
        {
           Console.Write($"{array[i]}, ");
        }
       Console.WriteLine();
    } 
    
}
double [] array = GetArray();

PrintArray(array);


Console.WriteLine($"Минимальный элемент: " + GetMinElementsArray(array));
Console.WriteLine($"Максимальный элемент: " + GetMaxElementsArray(array));
Console.WriteLine($"Разница между максимальным и минимальным элементом:"
                  + (GetMaxElementsArray(array) - GetMinElementsArray(array)));




