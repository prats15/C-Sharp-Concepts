using System;
using System.Collections.Generic;

//when yield return is used in a method, compiler creates a class with name (similar) to the method name and 
//implements IEnumerable<>, IEnumerable, IEnumerator<>, IEnumerator, IDisposable. That class is itself a IEnumerable and IEnumerator.

class MainClass
{
    static Random rand = new Random();

    static IEnumerable<int> GetRandomNumbers(int count) //if yield return is used, then GetRandomNumbers method is called 
    {                                                   //iterator method, return type has to be IEnumer....
        for (int i = 0; i < count; i++)
        {
            yield return rand.Next();           // this method will return instance of class created by compiler
        }                                       // which is both Enumerator and Enumerable...foreach works on every method
    }                                           // which yield returns

    static void Main()
    {
        foreach (int num in GetRandomNumbers(10))
        {
            Console.WriteLine(num);
        }
        Console.Read();
    }

    static IEnumerable<int> GetRandomNumbersWithoutYield(int count)  // returns list and foreach will use inbuilt 
    {                                                                // enumerator of list (enumerable)
        List<int> ints = new List<int>(count);    
        for (int i = 0; i < count; i++)
        {
            ints.Add(rand.Next());
        }
        return ints;
    }
}