using System;

namespace ArrayExtension
{
    public static class ArrayExtensions
    {
        public static int[] Square(this int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] * array[i];
            }
            return result;
        }

        public static int[] Cube(this int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] * array[i] * array[i];
            }
            return result;
        }

        public static double Average(this int[] array)
        {
            if (array.Length == 0)
            {
                return Double.NaN;
            }
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum / (double)array.Length;
        }

        public static int Sum(this int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        public static int[] Even(this int[] array)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }
            int[] result = new int[count];
            int index = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    result[index] = num;
                    index++;
                }
            }
            return result;
        }

        public static int[] Odd(this int[] array)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    count++;
                }
            }
            int[] result = new int[count];
            int index = 0;
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    result[index] = num;
                    index++;
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Введите элемент массива: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int[] squareArray = array.Square();
            Console.WriteLine("Массив, содержащий все значения, возведенные в квадрат:");
            foreach (int num in squareArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int[] cubeArray = array.Cube();
            Console.WriteLine("Массив, содержащий все значения, возведенные в куб:");
            foreach (int num in cubeArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            double average = array.Average();
            Console.WriteLine("Среднее значение всех значений массива: " + average);

            int sum = array.Sum();
            Console.WriteLine("Сумма всех значений массива: " + sum);

            int[] evenArray = array.Even();
            Console.WriteLine("Массив всех четных чисел:");
            foreach (int num in evenArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int[] oddArray = array.Odd();
            Console.WriteLine("Массив всех нечетных чисел:");
            foreach (int num in oddArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}