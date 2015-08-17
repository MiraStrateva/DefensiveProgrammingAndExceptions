using System;
using System.Collections.Generic;
using System.Text;

public class Exceptions
{
    public static void Main()
    {
        /// test Subsequence
        var charArray = "Hello!".ToCharArray();
        try
        {
            var substr = charArray.Subsequence(2, 3);
            Console.WriteLine(substr);
        }
        catch (ArgumentOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }

        var intArray = new int[] { -1, 3, 2, 1 };
        try
        {
            var subarr = intArray.Subsequence(3, 2);
            Console.WriteLine(string.Join(" ", subarr));
        }
        catch (ArgumentOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }

        try
        {
            var allarr = intArray.Subsequence(0, 4);
            Console.WriteLine(string.Join(" ", allarr));
        }
        catch (ArgumentOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }

        try
        { 
            var emptyarr = intArray.Subsequence(0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));
        }
        catch (ArgumentOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }

        /// Test ExtractEnding
        Console.WriteLine("I love C#".ExtractEnding(2));
        Console.WriteLine("Nakov".ExtractEnding(4));
        Console.WriteLine("beer".ExtractEnding(4));
        Console.WriteLine("Hi".ExtractEnding(100));

        /// Test CheckIfPrime
        int number = 23;
        if (number.CheckIfPrime())
        {
            Console.WriteLine("{0} is prime.", number);
        }
        else
        {
            Console.WriteLine("{0} is not prime", number);
        }

        number += 10;
        if (number.CheckIfPrime())
        {
            Console.WriteLine("{0} is prime.", number);
        }
        else
        {
            Console.WriteLine("{0} is not prime", number);
        }

        /// Test Exams classes
        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        Student georgi = new Student("Georgi", "Georgiev");

        try
        {
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("{1}: Average results = {0:p0}", peterAverageResult, peter.LastName);
            double georgiAverageResult = georgi.CalcAverageExamResultInPercents();
            Console.WriteLine("{1}: Average results = {0:p0}", georgiAverageResult, georgi.LastName);
        }
        catch (StudentExamsNotFoundException noExamsException)
        {
            Console.WriteLine(noExamsException.Message);
        }
    }
}
