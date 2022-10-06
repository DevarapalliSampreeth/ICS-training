using System;
class program1
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        int i, n, max, min;
        n = 5;
        min = arr[0];
        max = arr[0];
        for (i = 1; i < n; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.Write("minimum value={0}\n", min);
        Console.Write("maximum value={0}\n", max);
        Console.ReadLine();
    }
}

