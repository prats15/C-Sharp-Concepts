using System;
using System.Collections.Generic;

delegate bool MeDelegate(int number); 

class MainClass
{
    static bool GreaterThanTen(int number) { return number > 10; }   //these methods can be replaced by Lambda Expressions
    static bool LessThanFive(int number) { return number < 5; }

    static void Main()
    {
        IEnumerable<int> nums = new[] { 21, 2, 41, 3, 5, 1 , 63};

        IEnumerable<int> result1 = RunThroughTheNumbers(nums, GreaterThanTen);
        IEnumerable<int> result2 = RunThroughTheNumbers(nums, LessThanFive);

        Console.WriteLine("Greater than 10 -");
        foreach (int num in result1)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Less than 5 -");
        foreach (int num in result2)
        {
            Console.WriteLine(num);
        }

        Console.Read();
    }


    //instead of creating such duplicate methods, use delegates for conditions because you can pass code (method) using delegates
    static IEnumerable<int> RunThroughTheNumbers(IEnumerable<int> numbers, MeDelegate del)
    {
        foreach (int number in numbers)
        {
            if (del(number))
                yield return number;
        }
    }

    static IEnumerable<int> GetAllNumbersGreaterThanTen(IEnumerable<int> numbers)
    {
        foreach (int number in numbers)
        {
            if (number > 10)
                yield return number;
        }
    }

}