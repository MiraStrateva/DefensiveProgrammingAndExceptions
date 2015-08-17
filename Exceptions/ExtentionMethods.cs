using System;
using System.Collections.Generic;
using System.Text;

public static class ExtentionMethods
{
    public static string ExtractEnding(this string str, int count)
    {
        if (count > str.Length)
        {
            // get the whole string
            count = str.Length;
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static bool CheckIfPrime(this int number)
    {
        bool isPrime = true;

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                isPrime = false;
                break;
            }
        }

        return isPrime;
    }

    public static T[] Subsequence<T>(this T[] arr, int startIndex, int count)
    {
        if (startIndex < 0 || startIndex > arr.Length)
        {
            throw new ArgumentOutOfRangeException("Start Index is not in array range!");
        }

        if (startIndex + count > arr.Length)
        {
            throw new ArgumentOutOfRangeException("Count goes outside of array range!");
        }
        
        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }
}
