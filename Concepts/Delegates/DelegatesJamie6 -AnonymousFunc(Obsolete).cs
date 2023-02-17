using System;
using System.Collections.Generic;

//Anonymous functions serve the same purpose of lambda exp. Lambda is better.
//Anonymous functions were used before inception of Lambda exp.

class MainClass
{
    static void Main()
    {
        Func<int, bool> func = delegate(int i) { return i > 5; };  // Anonymous function
        Console.WriteLine(func(4));         
        Console.WriteLine(func(7));
        Console.Read();
    }
}


//Lambda Expressions
//static bool LessthanFive (int n) { return number < 5; }


//  static     bool           LessthanFive       (int n)          { return n < 5; }
// ignored   figures out        ignored         (n) or n         => n < 5 (it is returning result of expression ie. bool)
//          from return exp                     arguments