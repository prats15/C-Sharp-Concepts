using System;
using System.Collections.Generic;

//delegate T MeDelegate<T>(); 
//Usually, all delegates types are superimposed and satisfied by few Generic delegate types like -> Func, Action
//Func -> for methods that return a value, method can have max 16 input arguments + 1 output
//Action-> for methods that returns void, method can have max 16 input arguments + 1 output


class MainClass
{
    static void Main()
    {
        Func<int> d = Return5;
        d += Return20; 
        d += Return10;
        d += Return5;
        d += Return10;

        IEnumerable<int> ints = GetAllNumbers(d);

        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }

        Console.Read();
    }

    static IEnumerable<T> GetAllNumbers<T>(Func<T> d)
    {
        foreach (Func<T> del in d.GetInvocationList())   //List<T> ints = new List<T>();
            yield return del();                                //foreach (MeDelegate<T> del in d.GetInvocationList())
    }                                                          //{
                                                               //    ints.Add(del());
                                                               //}
                                                               //return ints;

    static int Return5() { return 5;  }
    static int Return10() { return 10; }
    static int Return20() { return 20; }
}