
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

        //foreach (int num in merged)
        //{
        //    Console.WriteLine(num);
        //}

        //int[] arr1 = [1, 2, 3];
        //int[] arr2 = [4, 5, 6];

        //List<int> list = new List<int>();

        //list.AddRange(arr1);
        //list.AddRange(arr2);

        //int[] merged = list.ToArray();

        //foreach(int num in merged)
        //{
        //    Console.WriteLine(num);
        //}

        //Find frequency of each number in array

        //int[] arr = { 1, 2, 3, 1, 2, 1, 4 };
        //List<int> counted = new List<int>();

        //foreach (int num in arr)
        //{
        //    if (!counted.Contains(num))
        //    {
        //        int count = 0;
        //        foreach (int n in arr)
        //            if (n == num)
        //                count++;

        //        Console.WriteLine($"{num} = {count} times");
        //        counted.Add(num);
        //    }
        //}

        //Find if a number exists in array

        int[] arr = [1, 2, 3, 5, 6, 55, 33, 2, 1, 5, 7,3];
        int num = 3;
        foreach(int n in arr)
        {
            if(n==num)
            {
                Console.WriteLine("It is Found");
                return;
            }          
        }
            Console.WriteLine("Not Found");
    }


}
