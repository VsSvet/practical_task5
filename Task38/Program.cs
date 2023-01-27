using System;
using static System.Console;

Clear();
WriteLine("Введите через пробел массив: ");
float[] array = new float[5];
array = GetArrayFromString(ReadLine());
WriteLine($"Разница между максимальным и минимальным элементов массива = {GetDifferenceMaxMin(array)}");




float[] GetArrayFromString(string stringArray)
{
    
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    float[] result = new float[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = float.Parse(numS[i]);
    }
    return result;
}

float GetDifferenceMaxMin(float[] array)
{
    float max = array[1];
    float min = array[1];

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return max-min;

}
