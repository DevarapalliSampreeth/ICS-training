﻿using System;
class program25
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[10];
        int n, i, j, tmp;

        Console.Write("enter size of array : ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter {0} marks in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("marks - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (arr1[j] < arr1[i])
                {
                    tmp = arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = tmp;
                }
            }
        }
        Console.Write("\nmarks of array in ascending order:\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("{0}  ", arr1[i]);
        }

    }

}
