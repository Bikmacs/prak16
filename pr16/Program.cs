using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        double[] arr = { 5.1, 1.3, 9.2, 2, 3, 5.1, 3 };

        // a) Вывод чисел и их частоты
        Dictionary<double, int> frequencyDict = new Dictionary<double, int>();
        foreach (double num in arr)
        {
            if (frequencyDict.ContainsKey(num))
            {
                frequencyDict[num]++;
            }
            else
            {
                frequencyDict[num] = 1;
            }
        }

        Console.WriteLine("Число : Частота");
        foreach (var kvp in frequencyDict)
        {
            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }

       
        List<double> newArr = new List<double>();
        foreach (double num in arr)
        {
            newArr.Add(num * frequencyDict[num]);
        }

        Console.WriteLine("Новый массив после умножения на частоту:");
        foreach (double num in newArr)
        {
            Console.Write(num + " ");
        }
    }
}
