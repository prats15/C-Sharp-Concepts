using System;
using System.Collections.Generic;

class MainClass
{
    static void Main()
    {
        Action a = GiveMeAction();
        a(); a(); a();

        Console.Read();
    }

    static Action GiveMeAction()   // this method returns another method in form of lambda exp, that returned method captures
    {                              // the scope of 'i', which is called as closure. Value of i is intact in main()
        Action ret = null;
        int i = 0;
        ret += () =>
        {                                          // { } can be used in lambda, in that case, 
            Console.WriteLine("First Method " + i++);     // use 'return' keyword if something is returned by lambda exp
        };
        ret += () =>
        {
            Console.WriteLine("Second Method " + i++);    //'i' is accessible in main too
        };
        return ret;
    }
}

//below mentioned code works too

//using System;
//using System.Collections.Generic;

//class MainClass
//{
//    static void Main()
//    {
//        Action a = GiveMeAction();
//        a(); a(); a();

//        Console.Read();
//    }

//    static Action GiveMeAction()
//    {
//        int i = 0;
//        Action action = () => i++;
//        action += () => i++;
//        action += () => i++;
//        action += () => i++;
//        action += () => Console.WriteLine("i now is : {0}", i);
//        return action;
//    }
//}

