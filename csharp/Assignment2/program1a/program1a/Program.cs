using System;
class program1
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int i = 0;
        int sum = 0;
        float average = 0.0F;
        for (i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        average = sum / arr.Length;
        Console.WriteLine("average of array elements: " + average);
        Console.ReadLine();
    }
}