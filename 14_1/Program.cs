using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер ромба: ");
        int size = int.Parse(Console.ReadLine());

        // Проверяем, является ли введенное число четным или отрицательным
        if (size % 2 == 0 || size < 0)
        {
            Console.WriteLine("null");
        }
        else
        {
            // Выводим верхнюю половину ромба
            for (int i = 0; i < (size + 1) / 2; i++)
            {
                for (int j = 0; j < (size - 1) / 2 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Выводим нижнюю половину ромба
            for (int i = (size - 1) / 2 - 1; i >= 0; i--)
            {
                for (int j = 0; j < (size - 1) / 2 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}