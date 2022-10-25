// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

int[] createArray()
{
int[] N = new int [8]; 
Random ran = new Random();
for (int i = 0; i < N.Length; i++) { N[i] = ran.Next(); }
 return N;
}

string GetArrayAsString(int[] array)
{
    string Result = " ";
    for (int i = 0; i < array.Length; i++)
    { 
    Result+=$"{array[i].ToString()}| ";
    }
    return Result;
}    
Console.WriteLine(GetArrayAsString(createArray()));

   

    
