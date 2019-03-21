using System;
using System.Collections.Generic;

class GFG
{
    // Array of items on which  
    // search will be conducted. 
    static int[] arr; 

    // If x is present in  
    // arr[0..n-1], then  
    // returns index of it,  
    // else returns -1. 
    static int interpolationSearch(int x)
    {
        // Find indexes of 
        // two corners 
        int lo = 0, hi = (arr.Length - 1);

        // Since array is sorted,  
        // an element present in 
        // array must be in range 
        // defined by corner 
        while (lo <= hi &&
                x >= arr[lo] &&
                x <= arr[hi])
        {
            // Probing the position  
            // with keeping uniform  
            // distribution in mind. 
            int pos = lo + (((hi - lo) /
                             (arr[hi] - arr[lo])) *
                                   (x - arr[lo]));

            // Condition of  
            // target found 
            if (arr[pos] == x)
                return pos;

            // If x is larger, x 
            // is in upper part 
            if (arr[pos] < x)
                lo = pos + 1;

            // If x is smaller, x  
            // is in the lower part 
            else
                hi = pos - 1;
        }
        return -1;
    }

    // Driver Code  
    public static void Main()
    {
        try
        {
            List<int> lst = new List<int>();
            arr = new int[18];
            int contor = 0;
            string[] stringArray = System.IO.File.ReadAllLines(@"file.txt");
            foreach (string example in stringArray)
            {
                lst.Add(Convert.ToInt32(example.Trim()));
                arr[contor] = Convert.ToInt32(example.Trim());
                ++contor;
            }
        }
        catch(Exception)
        {
            Console.WriteLine("Ошибка типа данных!");
            Environment.Exit(10);
        }
        Console.WriteLine("Исходный массив:{0}   ", String.Join(" ", arr));
        Console.WriteLine("Перед началом поиска следует отсортировать массив, желаете это сделать? y/n");
        string sort = Console.ReadLine();
        if (sort == "y")
        {
            Array.Sort(arr);
            Console.WriteLine("Отсортированный массив:{0}   ", String.Join(" ", arr));
        }
        else
        {
            Environment.Exit(0);
        }
        Console.WriteLine("Введите искомый элемент: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int index = interpolationSearch(x);

        // If element was found 
        if (index != -1)
            Console.WriteLine("Элемент найден под индексом " + index);
        else
            Console.WriteLine("Элемент не найден");
        Console.ReadKey();
    }
}