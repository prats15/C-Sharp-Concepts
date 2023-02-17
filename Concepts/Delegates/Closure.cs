using System;
using System.Collections.Generic;

class MainClass
{
    static void Main()
    {
        int i = 0;
        Action a = () => i++; //lambda with no input args, hence ()

        a();   //notice that it seems like, 'i' is not in the scope of method created by lambda
        a();   
        a();

        Console.WriteLine(i); // output = 3

        Console.Read();
    }
}
