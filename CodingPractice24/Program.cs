
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

        //int[] arr = [1, 2, 3, 5, 6, 55, 33, 2, 1, 5, 7,3];
        //int num = 3;
        //foreach(int n in arr)
        //{
        //    if(n==num)
        //    {
        //        Console.WriteLine("It is Found");
        //        return;
        //    }          
        //}
        //    Console.WriteLine("Not Found");

        //Get all even numbers from a list

        //int[] arr = [1, 2, 3, 4, 55, 44, 9, 555, 66, 22, 34, 78, 12];

        //var evennumbers = arr.Where(x => x % 2 == 0);

        //Console.WriteLine("The even numbers are");

        //foreach(var num in evennumbers)
        //{
        //    Console.WriteLine(num);
        //}

        //Get all odd numbers from a list

        //int[] arr = [1, 4,6,8, 33, 9, 45,  78, 98,543];

        //var oddnumbers = arr.Where(x => x % 2 != 0);

        //Console.WriteLine("The odd numbers are");

        //foreach(var num in oddnumbers)
        //{
        //    Console.WriteLine(num);
        //}

        //Find the largest number using LINQ

        //Console.WriteLine("Enter Numbers");

        //string input = Console.ReadLine();

        //int[] arr = input.Split(' ').Select(x => int.Parse(x)).ToArray();

        //int largest = arr.Max();

        //Console.WriteLine("The largest number is " + largest);

        //Find the smallest number using LINQ

        //Console.WriteLine("Enter Numbers");
        //string input = Console.ReadLine();

        //int[] arr = input.Split(' ').Select(x => int.Parse(x)).ToArray();

        //int smallest = arr.Min();

        //Console.WriteLine("The smallest number is " + smallest);

        //Find the sum of all numbers

        //Console.WriteLine("Enter a numbers");
        //string input = Console.ReadLine();

        //int[] arr = input.Split(' ').Select(x => int.Parse(x)).ToArray();

        //int sum = arr.Sum();

        //Console.WriteLine("The sum is " + sum);

        // Find the average of all numbers

        //Console.WriteLine("Enter a numbers");
        //string input = Console.ReadLine();

        //double[] arr = input.Split(' ').Select(x => double.Parse(x)).ToArray();

        //double avg = arr.Average();

        //Console.WriteLine("The average is" + avg);

        //Filter numbers greater than 10 using linq

        //Console.WriteLine("Enter numbers");
        //string input = Console.ReadLine();

        //int[] arr = input.Split(' ').Select(x => int.Parse(x)).ToArray();

        //var numbers = arr.Where(x => x > 10);

        //    foreach(int num in numbers)
        //{
        //    Console.WriteLine(num);
        //}

        //Get first 3 elements from a list


        //List<int> numbers = new List<int> { 1, 6, 9, 3, 2, 1, 55, 676, 44, 22, 2 };

        //var firstthree = numbers.Take(3);

        //foreach(var num in firstthree)
        //{
        //    Console.WriteLine(num);
        //}

        // Skip first 3 elements and get rest

        //List<int> numbers = new List<int> { 4, 8, 8, 9, 22, 12, 99, 56, 32 };

        //var restnumbers = numbers.Skip(3);

        //foreach(var num in restnumbers)
        //{
        //    Console.WriteLine(num);
        //}

        //Remove duplicates from a list

        //List<int> numbers = new List<int> { 1, 55,55, 1,7, 7, 88, 89, 45, 34, 23, 3, 33, 333 };

        //var dupnumbers = numbers.Distinct();

        //foreach(var num in dupnumbers)
        //{
        //    Console.WriteLine(num);
        //}

        //Reverse a list using LINQ

        // Console.WriteLine("Enter a numbers");
        // string input = Console.ReadLine();

        //int[] arr = input.Split(' ').Select(x=>int.Parse(x)).ToArray();

        // var numbers = arr.Reverse();

        //     foreach(var num in numbers)
        // {
        //     Console.WriteLine(num);
        // }

        //Check if number  exists using linq

        //List<int> numbers = new List<int> { 1, 2, 55, 67, 34, 12, 78, 33, 55, 1 };

        //int searchNumber = 2;

        //bool exists = numbers.Contains(searchNumber);


        //    if (exists)
        //    {
        //        Console.WriteLine("It is found");
        //    }
        //    else
        //    {
        //        Console.WriteLine("It is Not Found");
        //    }

        //Reverse the string using loop

        //Console.WriteLine("Enter a string");
        //string str = Console.ReadLine();

        //string reversed = "";

        //for (int i = str.Length - 1; i >= 0; i--)
        //{
        //    reversed += str[i];          
        //}
        //Console.WriteLine(reversed);

        //reverse each character of word in given sentence

        Console.WriteLine("Enter a sentence");
        string str = Console.ReadLine();

        string[] words = str.Split(' ');

        string result = "";

        foreach (string word in words)
        {
            string reversedsentence = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedsentence += word[i];
            }

            result += reversedsentence + " ";
        }
        Console.WriteLine(result);
    }
    }

