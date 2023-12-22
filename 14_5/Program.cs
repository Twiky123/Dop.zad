using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в списке: ");
        int count = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите элементы списка через пробел:");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int closestNumber = FindClosestToZero(numbers);

        if (closestNumber == int.MinValue)
        {
            Console.WriteLine("None");
        }
        else
        {
            Console.WriteLine(closestNumber);
        }
    }

    static int FindClosestToZero(int[] numbers)
    {
        int closestNumber = int.MaxValue;
        bool multipleClosestNumbers = false;

        foreach (int number in numbers)
        {
            if (number == 0)
            {
                return 0;
            }

            if (Math.Abs(number) < Math.Abs(closestNumber))
            {
                closestNumber = number;
                multipleClosestNumbers = false;
            }
            else if (Math.Abs(number) == Math.Abs(closestNumber))
            {
                multipleClosestNumbers = true;
            }
        }

        if (multipleClosestNumbers)
        {
            return int.MinValue;
        }
        else
        {
            return closestNumber;
        }
    }
}