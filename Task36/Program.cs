using System;
using static System.Console;

Clear();
int size = 4;
int[] array = GetArray(size);
WriteLine(String.Join(",", array));
int Sum = 0;

for(int i = 0; i < size; i++)
{
    if(i % 2 != 0)
    {
        Sum += array[i];
    }
    
}


WriteLine($"Сумма элементов, стоящих на нечётных позициях = {Sum}");


int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}