using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(',');

        string[] resultArray = FilterArray(originalArray);

        Console.WriteLine("Результат:");
        foreach (string s in resultArray)
        {
            Console.Write(s + " ");
        }
    }

    static string[] FilterArray(string[] arr)
    {
        int count = 0;
        foreach (string s in arr)
        {
            if (s.Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        foreach (string s in arr)
        {
            if (s.Length <= 3)
            {
                result[index] = s;
                index++;
            }
        }
        return result;
    }
}
