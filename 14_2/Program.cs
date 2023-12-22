using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк:");
        int n = int.Parse(Console.ReadLine());

        string[] strings = new string[n];

        Console.WriteLine($"Введите {n} строк:");
        for (int i = 0; i < n; i++)
        {
            strings[i] = Console.ReadLine();
        }

        string[] sortedStrings = SortStringsByLength(strings);

        Console.WriteLine("Отсортированные строки:");
        foreach (string str in sortedStrings)
        {
            Console.WriteLine(str);
        }
    }

    static string[] SortStringsByLength(string[] strings)
    {
        Array.Sort(strings, (a, b) => a.Length.CompareTo(b.Length));
        return strings;
    }
}