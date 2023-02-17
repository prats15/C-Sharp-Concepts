using System;
using System.Collections.Generic;

class MainClass
{
    static void Main()
    {
        Action a = GiveMeAction();   //both a and b have their own independent 'i', 
        Action b = GiveMeAction();   //value of 'i' after performing a thrice will be 3
        a(); b(); a(); b(); a();     //value of 'i' after performing a twice will be 2

        Console.Read();
    }

    static Action GiveMeAction()     // this method returns another method in form of lambda exp, that returned
    {                                // method captures the scope of 'i', which is called as closure, that scope is
        int i = 0;                   // still intact in main method. 'i' keeps incrementing if we call a() in main
        return () => i++;
    }
}

//scope of i is intact because, whenever we return a lambda exp, compiler generates a class (with name similar to GiveMeAction)
//that class contains field 'i' and a method, and that method is returned whenever we say Action a = GiveMeAction();
//this way every Action has their own 'i'. And the scope of 'i' is increased because the class is generated in the MainClass
