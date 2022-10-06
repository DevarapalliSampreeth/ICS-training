using System;
class program2
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[100];
        int i, max, min, n;

        Console.Write("enter no of sub the marks :");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter marks in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("marks -{0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }


        max = arr1[0];
        min = arr1[0];

        for (i = 1; i < n; i++)
        {
            if (arr1[i] > max)
            {
                max = arr1[i];
            }


            if (arr1[i] < min)
            {
                min = arr1[i];
            }
        }
        Console.Write("Maximum marks is : {0}\n", max);
        Console.Write("Minimum marks is : {0}\n\n", min);
    }
}

