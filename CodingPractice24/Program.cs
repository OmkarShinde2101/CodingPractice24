
using System;

class Program
{
    //static void Main()
    //{
    //    Console.WriteLine("Hello Coding Practice!");
    //}

    static void Main()
    {
        //int[] arr1 = [1, 2, 3];
        //int[] arr2 = [4, 5, 6];

        //int[] merged = arr1.Concat(arr2).ToArray();

        //foreach(int num in merged)
        //{
        //    Console.WriteLine(num);
        //}

        int[] arr1 = [1, 2, 3];
        int[] arr2 = [4, 5, 6];

        List<int> list = new List<int>();

        list.AddRange(arr1);
        list.AddRange(arr2);

        int[] merged = list.ToArray();

        foreach(int num in merged)
        {
            Console.WriteLine(num);
        }

    }
}