using System;
using System.Collections.Generic;

class MainClass
{
    static void Main()
    {
        Action del = (Action)Moo + BeNaughty + Goo;  //Moo + BeNaughty + Goo does not work...you have to cast atleast first one (Action)

        foreach (Action d in del.GetInvocationList())
        {
            try
            {
                d();
            }
            catch {}
        }
        Console.Read();
    }

    static void Moo() { Console.WriteLine("Moo"); }
    static void BeNaughty() { throw new Exception(); }
    static void Goo() { Console.WriteLine("Goo"); }
}