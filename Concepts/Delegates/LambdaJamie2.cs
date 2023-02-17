using System;
using System.Collections.Generic;

class MainClass
{
    static void Main()
    {
        Func<int, bool> func = i => i > 5;  //in Func<int, bool>, int is the type of argument1, bool is return type
        Console.WriteLine(func(4));         //from ( i => ) compilers figures out, 'i' is int and (i > 5) returns bool
        Console.WriteLine(func(7));
        Console.Read();
    }
}


//Lambda Expressions
//static bool LessthanFive (int n) { return number < 5; }


//  static     bool           LessthanFive       (int n)          { return n < 5; }
// ignored   figures out        ignored         (n) or n         => n < 5 (it is returning result of expression ie. bool)
//          from return exp                     arguments