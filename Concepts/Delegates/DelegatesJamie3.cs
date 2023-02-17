using System;
using System.Collections.Generic;

delegate T MeDelegate<T>(); 

class MainClass
{
    static void Main()
    {
        MeDelegate<int> d = Return5;
        d += Return20; 
        d += Return10;
        d += Return5;
        d += Return10;

        IEnumerable<int> ints = GetAllNumbers<int>(d);

        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }

        Console.Read();
    }

    static IEnumerable<T> GetAllNumbers<T>(MeDelegate<T> d)
    {
        foreach (MeDelegate<T> del in d.GetInvocationList())   //List<T> ints = new List<T>();
            yield return del();                                //foreach (MeDelegate<T> del in d.GetInvocationList())
    }                                                          //{
                                                               //    ints.Add(del());
                                                               //}
                                                               //return ints;

    static int Return5() { return 5;  }
    static int Return10() { return 10; }
    static int Return20() { return 20; }
}