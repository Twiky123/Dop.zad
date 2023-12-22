using System;

public class CountSmileys
{
    public static int CountSmileyFaces(string[] arr)
    {
        int count = 0;

        foreach (string face in arr)
        {
            if (IsValidSmileyFace(face))
            {
                count++;
            }
        }

        return count;
    }

    private static bool IsValidSmileyFace(string face)
    {
        if (face.Length == 2 || face.Length == 3)
        {
            char eyes = face[0];
            char mouth = face[face.Length - 1];

            if ((eyes == ':' || eyes == ';') && (mouth == ')' || mouth == 'D'))
            {
                if (face.Length == 3)
                {
                    char nose = face[1];

                    if (nose != '-' && nose != '~')
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        return false;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите количество улыб. лиц:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите лицо:");

        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
        }

        int count = CountSmileyFaces(arr);

        Console.WriteLine("Общее количество лиц: " + count);
    }
}