
using System;
using System.Threading.Channels;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        //    Console.WriteLine("Hello Coding Practice!");
        //}

        //static void Main()
        //{
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

        //Console.WriteLine("Enter a sentence");
        //string str = Console.ReadLine();

        //string[] words = str.Split(' ');

        //string result = "";

        //foreach (string word in words)
        //{
        //    string reversedsentence = "";

        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        reversedsentence += word[i];
        //    }

        //    result += reversedsentence + " ";
        //}
        //Console.WriteLine(result);

        //remove duplicate charcater from string

        //Console.WriteLine("Enetra a string");
        //string str = Console.ReadLine();

        //string result = "";

        //for(int i=0; i<str.Length; i++)
        //{
        //    if (!result.Contains(str[i]))
        //    {
        //        result += str[i];
        //    }
        //}
        //Console.WriteLine(result);

        //convert degree celcous to fahreinheit

        //Console.WriteLine("Enter a temp");
        //double num = Convert.ToDouble(Console.ReadLine());

        //double far = (9 / 5) * num + 32;

        //Console.WriteLine(far);

        //find longestword in sentence

        //Console.WriteLine("Enter a word");
        //string str = Console.ReadLine();

        //string[] words = str.Split(' ');

        //string longestword = "";

        //foreach (string word in words)
        //{
        //    if (word.Length > longestword.Length)
        //    {
        //        longestword = word;
        //    }
        //}
        //Console.WriteLine(longestword);

        //Create a Student class

        //Properties: Name, Age
        //Constructor to set Name and Age
        //Method to print student details

        //    class Student
        //{
        //    // Properties
        //    string Name;
        //    int Age;

        //    // Constructor
        //    public Student(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }

        //    // Method
        //    public void PrintDetails()
        //    {
        //        Console.WriteLine($"Name: {Name}");
        //        Console.WriteLine($"Age: {Age}");
        //    }
        //}

        //class Program
        //{
        //    static void Main()
        //    {
        //        // Object
        //        Student s1 = new Student("Omkar", 21);
        //        s1.PrintDetails();
        //    }
        //}

        //Find second largest number

        //Console.WriteLine("Enter a numbers");
        //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //Array.Sort(arr);

        //int secondlargestnumber = arr[arr.Length - 2];

        //Console.WriteLine(secondlargestnumber);

        //sort array without using sort

        //int[] arr = { 9, 3, 33, 56 };

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    for (int j = i + 1; j < arr.Length; j++)
        //    {
        //        if (arr[i] > arr[j])
        //        {
        //            int temp = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = temp;
        //        }
        //    }
        //}
        //foreach (int num in arr)
        //{
        //    Console.WriteLine(num);
        //}

        //swap the position of array first and last

        //int[] arr = { 99, 56, 54, 143 };

        //int i = 0;
        //int j = arr.Length - 1;

        //int temp = arr [i];
        //arr[i] = arr [j];
        //arr [j] = temp;

        //foreach (int num in arr)
        //{
        //    Console.WriteLine(num);
        //}

        //reverse the array without using inbuild functions

        //int[] arr = { 2, 6, 89, 12, 1667 };

        //for (int i = arr.Length - 1; i >= 0; i--)
        //{
        //    Console.WriteLine(arr[i]);
        //}

        //Count how many are True in boolean

        //bool[] arr = { false, true, true, false, false, true };

        //int count = 0;

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] == true)
        //    {
        //        count++;
        //    }           
        //}
        //Console.WriteLine(count);

        //Count how many are false in boolean

        //bool[] arr = { true, false, true, true, false };

        //int count = 0;

        //for(int i=0; i<arr.Length; i++)
        //{
        //    if (arr[i] == false)
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine(count);

        //Count True and False both

        //bool[] arr = { true, false, false, true, true };

        //int count1 = 0;
        //int count2 = 0;

        //for(int i=0; i<arr.Length; i++)
        //{
        //    if (arr[i]== true)
        //    {
        //        count1++;
        //    }
        //    else
        //    {
        //        count2++;
        //    }
        //}
        //Console.WriteLine(count1);
        //Console.WriteLine(count2);

        //reverse the string using loop 

        //Console.WriteLine("Enter a string");
        //string str = Console.ReadLine();
        //string reversed = "";

        //for(int i=str.Length-1; i>=0; i--)
        //{
        //    reversed += str[i];
        //}
        //Console.WriteLine(reversed);

        //How to find given string is palindrome or not

        //Console.WriteLine("Enter  a string");
        //string str = Console.ReadLine();

        //string reversed = "";

        //for(int i=str.Length-1; i>=0; i--)
        //{
        //    reversed += str[i];
        //}

        //if(reversed == str)
        //{
        //    Console.WriteLine("It is palindrome");
        //}
        //else
        //{
        //    Console.WriteLine("It is not palindrome");
        //}

        //How to find given integer is palindrome or not

        //Console.WriteLine("Enter a Integer");
        //int num = Convert.ToInt32(Console.ReadLine());

        //string numStr = num.ToString();

        //string reversed = "";

        //for (int i = numStr.Length - 1; i >= 0; i--)
        //{
        //    reversed += numStr[i];
        //}
        //int reversedNum = Convert.ToInt32(reversed);

        //if (reversedNum == num)
        //{
        //    Console.WriteLine("It is palindrome");
        //}
        //else
        //{
        //    Console.WriteLine("It is not palindrome");
        //}

        //How to reverse the order of words in a given sentence

        //Console.WriteLine("Enter a sentence");
        //string[] str = Console.ReadLine().Split(' ');

        //string reversed = "";

        //for (int i = str.Length - 1; i >= 0; i--)
        //{
        //    reversed += str[i] + " ";
        //}
        //Console.WriteLine(reversed );

        //How to reverse each character of word in a given string sentence but keep it in same position

        //Console.WriteLine("Enter a sentence");
        //string[] str = Console.ReadLine().Split(' ');

        //string result = "";

        //foreach (string word in str)
        //{
        //    string reversed = "";

        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        reversed += word[i];
        //    }
        //    result += reversed + " ";
        //}
        //Console.WriteLine(result);

        //remove duplicate character from string

        //Console.WriteLine("Ennter a string");
        //string str = Console.ReadLine();

        //string result = "";

        //for (int i = 0; i < str.Length; i++)
        //{
        //    int count = 0;

        //    for (int j = 0; j < result.Length; j++)
        //    {
        //        if (str[i] == result[j])
        //        {
        //            count++;
        //        }
        //    }
        //    if (count == 0)
        //    {
        //        result += str[i];
        //    }
        //}
        //Console.WriteLine(result);

        //sort the array wiout using sort

        //Console.WriteLine("Enter a string:");
        //string input = Console.ReadLine();

        //char[] arr = input.ToCharArray();

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    for (int j = i + 1; j < arr.Length; j++)
        //    {
        //        if (arr[i] > arr[j])  
        //        {
        //            char temp = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = temp;
        //        }
        //    }
        //}
        //string result = new string(arr);
        //Console.WriteLine("Sorted string: " + result);

        //check the anagrm

        //Console.WriteLine("Enter a string1");
        //string str1 = Console.ReadLine();

        //Console.WriteLine("Enter a string2");
        //string str2 = Console.ReadLine();

        //char[] arr1 = str1.ToCharArray();
        //char[] arr2 = str2.ToCharArray();

        //for(int i=0; i<arr1.Length; i++)
        //{
        //    for(int j=i+1; j<arr1.Length; j++)
        //    {
        //        if (arr1[i]> arr1[j])
        //        {
        //            char temp = arr1[i];
        //            arr1[i] = arr1[j];
        //            arr1[j] = temp;
        //        }
        //    }
        //}
        //string result1 = new string(arr1);
        //Console.WriteLine(result1);

        //for(int m=0; m<arr2.Length; m++)
        //{
        //    for(int n=m+1; n<arr2.Length; n++)
        //    {
        //        if (arr2[m] > arr2[n])
        //        {
        //            char swap = arr2[m];
        //            arr2[m] = arr2[n];
        //            arr2[n] = swap;
        //        }
        //    }
        //}
        //string result2 = new string(arr2);
        //Console.WriteLine(result2);

        //if(result1 == result2)
        //{
        //    Console.WriteLine("It is anagram");
        //}
        //else
        //{
        //    Console.WriteLine("It is not anagram");
        //}

        //remove space from the strig without using inbuild function

        //Console.WriteLine("Enter a string");
        //string str = Console.ReadLine();
        //string result = "";

        //for(int i= 0; i<str.Length; i++)
        //{
        //    if (str[i] != ' ')
        //    {
        //        result = result + str[i];
        //    }
        //}

        //Console.WriteLine(result);

        //remove space from string using boolean

        //Console.WriteLine("Enter a string");
        //string str = Console.ReadLine();
        //string result = "";

        //for(int i=0; i<str.Length;  i++)
        //{
        //    bool isSpace = (str[i] == ' ');

        //    if (isSpace == false)
        //    {
        //        result = result + str[i];
        //    }
        //}
        //Console.WriteLine(result);

        //find longest word in sentence

        //Console.WriteLine("Enter a sentence");
        //string str = Console.ReadLine();

        //string[] words = str.Split(' ');

        //string longestword = "";

        //foreach (string word in words)
        //{
        //    if (word.Length > longestword.Length)
        //    {
        //        longestword = word;
        //    }
        //}
        //Console.WriteLine(longestword);

        //find longestword in sentence using boolean

        //Console.WriteLine("Entaer  a sentence");
        //string str = Console.ReadLine();

        //string[] words = str.Split(' ');
        //string longestword = "";
        //bool firstword = true;

        //foreach(string word in words)
        //{
        //    if(firstword == true)
        //    {
        //        longestword = word;
        //        firstword = false;
        //    }
        //    else if (word.Length>longestword.Length)
        //            {
        //        longestword = word;
        //    }
        //}
        //Console.WriteLine(longestword);

        //Find largest and smallest element in an array

        //Console.WriteLine("Enter a Numbers");
        //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    for (int j = i + 1; j < arr.Length; j++)
        //    {
        //        if (arr[i] > arr[j])
        //        {
        //            int swap = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = swap;
        //        }
        //    }
        //}

        //int smallest = arr[0];
        //int largest = arr[arr.Length - 1];
        //int secondlargest = arr[arr.Length - 2];

        //Console.WriteLine(smallest);
        //Console.WriteLine(largest);
        //Console.WriteLine(secondlargest);

        //find largest and smallest using boolean

        //Console.WriteLine("Enter Numbers");
        //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //int smallest = 0;
        //int largest = 0;

        //bool first = true;

        //foreach (int num in arr)
        //{
        //    if (first == true)
        //    {
        //        smallest = num;
        //        largest = num;
        //        first = false;
        //    }
        //    else
        //    {
        //        if (num < smallest)
        //            smallest = num;

        //        if (num > largest)
        //            largest = num;
        //    }
        //}

        //Console.WriteLine("Smallest: " + smallest);
        //Console.WriteLine("Largest: " + largest);

        //reverse the array without using inbuild function

        //Console.WriteLine("Enter a Number");
        //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //for(int i=arr.Length-1; i>=0; i--)
        //{
        //    Console.WriteLine(arr[i]);
        //}

        //remove duplicate elements from array

        //Console.WriteLine("Enter elements");
        //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //// Step 1: Sort manually
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    for (int j = i + 1; j < arr.Length; j++)
        //    {
        //        if (arr[i] > arr[j])
        //        {
        //            int temp = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = temp;
        //        }
        //    }
        //}

        //// Step 2: Print unique elements
        //Console.WriteLine(arr[0]);

        //for (int i = 1; i < arr.Length; i++)
        //{
        //    if (arr[i] != arr[i - 1])
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}

        //sort array without using sort

        //Console.WriteLine("Enter a numbers");
        //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //for(int i=0; i<arr.Length; i++)
        //{
        //    for(int j=i+1; j<arr.Length; j++)
        //    {
        //        if (arr[i]> arr[j])
        //        {
        //            int swap = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = swap;
        //        }
        //    }
        //}
        //foreach(int num in arr)
        //{
        //    Console.WriteLine(num);
        //}

        //reverse the array numbers

        //Console.WriteLine("Enter a Numbers");
        //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //for(int i=arr.Length-1; i>=0; i--)
        //{
        //    Console.WriteLine(arr[i]);
        //}

        //revese the array numbers when they are in same position

        //Console.WriteLine("Enter numbers:");
        //string[] arr = Console.ReadLine().Split(' ');

        //foreach (string num in arr)
        //{
        //    string rev = "";

        //    for (int i = num.Length - 1; i >= 0; i--)
        //    {
        //        rev += num[i];
        //    }
        //    Console.Write(rev + " ");
        //}

        //reverse the string using loop

        //Console.WriteLine("Enter a string");
        //string str = Console.ReadLine();

        //string reversed = "";

        //for(int i = str.Length-1; i>=0; i--)
        //{
        //    reversed += str[i];
        //}
        //Console.WriteLine(reversed);

        //reverse the order of word in given  sentence using loop 

        //Console.WriteLine("Enter a sentence");
        //string[] str = Console.ReadLine().Split(' ');

        //string reversed = "";

        //for(int i=str.Length-1; i>=0; i--)
        //{
        //    reversed += str[i] + " ";
        //}
        //Console.WriteLine(reversed);

        //reverse the word in sentence but keep in there same position using loop

        //Console.WriteLine("Enter a sentence");
        //string[] str = Console.ReadLine().Split(' ');

        //string rev = "";

        //foreach (string st in str)
        //{
        //    string reversed = "";

        //    for (int i = st.Length - 1; i >= 0; i--)
        //    {
        //        reversed += st[i];
        //    }
        //    rev += reversed + " ";
        //}
        //Console.WriteLine(rev);

        //reverse the single number

        //Console.WriteLine("Enter a Number");
        //string str = Console.ReadLine();

        //string reversed = "";

        //for(int i=str.Length-1; i>=0; i--)
        //{
        //    reversed += str[i];
        //}
        //Console.WriteLine(reversed);

        //reverse the position of numbers

        //Console.WriteLine("Enter a Number");
        //string[] str = Console.ReadLine().Split(' ');

        //string reversed = "";

        //for(int i=str.Length-1; i>=0; i--)
        //{
        //    reversed += str[i] + " ";
        //}
        //Console.WriteLine(reversed);

        //reverse the numbers but keep it in same position

        //Console.WriteLine("Enter a Numbers");
        //string[] str = Console.ReadLine().Split(' ');

        //string reversed = "";

        //foreach(string st in str)
        //{
        //    string rev = "";

        //    for(int i=st.Length-1; i>=0; i--)
        //    {
        //        rev += st[i];
        //    }
        //    reversed += rev + " ";
        //}
        //Console.WriteLine(reversed);

        //remove duplicate character from sentence using loop keep it in there same position 

        //Console.WriteLine("Enter a string");
        //string str = Console.ReadLine();


        //    string result = "";

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        int count = 0;
        //        for (int j = 0; j < i; j++)
        //        {
        //            if (str[i] == result[j])
        //            {
        //                count++;
        //            break;
        //            }
        //        }

        //        if (count == 0)
        //        {
        //            result += str[i] ;
        //        }
        //    }
        //    Console.WriteLine(result);



        //Console.WriteLine("Enter a string");
        //string str = Console.ReadLine();

        //string result = "";

        //for (int i = 0; i < str.Length; i++)
        //{
        //    int count = 0;

        //    for (int j = 0; j < i; j++)   
        //    {
        //        if (str[i] == str[j])
        //        {
        //            count++;
        //            break;
        //        }
        //    }

        //    if (count == 0)
        //    {
        //        result += str[i];   // keep first occurrence only
        //    }
        //}

        //Console.WriteLine(result);

        // remove duplicate character from sentence using loop keep it in there same position 

        //Console.WriteLine("Enter a string");
        //string str = Console.ReadLine();

        //string seen = "";
        //string result = "";

        //for (int i = 0; i < str.Length; i++)
        //{
        //    if (str[i] == ' ')
        //    {
        //        result += " ";   
        //        continue;
        //    }

        //    int count = 0;

        //    for (int j = 0; j < seen.Length; j++)
        //    {
        //        if (str[i] == seen[j])
        //        {
        //            count++;
        //            break;
        //        }
        //    }

        //    if (count == 0)
        //    {
        //        result += str[i];
        //        seen += str[i];
        //    }
        //}

        //Console.WriteLine(result);

        //remove the duplicate numbers

        //Console.WriteLine("Enter a Numbers");
        //string str = Console.ReadLine();

        //string result = "";

        //for(int i=0; i<str.Length; i++)
        //{
        //    int count = 0;
        //    for(int j=0; j<result.Length; j++)
        //    {
        //        if (str[i] == str[j])
        //        {
        //            count++;
        //            break;
        //        }    
        //    }
        //    if(count==0)
        //    {
        //        result += str[i];
        //    }
        //}
        //Console.WriteLine(result);

        //remove duplicate numbers when it is separted

         Console.WriteLine("Enter a numbers");
        string str = Console.ReadLine();

        string seen = "";
        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                result += " ";
                continue;
            }

            int count = 0;

            for (int j = 0; j < seen.Length; j++)
            {
                if (str[i] == seen[j])
                {
                    count++;
                    break;
                }
            }

            if (count == 0)
            {
                result += str[i];
                seen += str[i];
            }
        }

        Console.WriteLine(result);

    }


}







