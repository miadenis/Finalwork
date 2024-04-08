// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] originalArray = { "1234", "1567", "-2", "computer science" };
        int count = 0;

        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;
        
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                newArray[index] = originalArray[i];
                index++;
            }
        }
        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
    }
}
