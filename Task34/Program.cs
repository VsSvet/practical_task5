using System;
using static System.Console;

Clear();
int[] array = GetArray(4);
WriteLine(String.Join(",", array));
int Sum = 0;
foreach(int item in array)
{
    if(item % 2 == 0)
    {
        Sum++;
    }
    
}


WriteLine($"Количество четных чисел = {Sum}");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}
