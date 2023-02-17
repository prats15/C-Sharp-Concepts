using System;

delegate void MeDelegate(); //creates a class for delegate type

//ctor of delegate class takes object (aka target) and method (address) as arguments 
//for static methods object is null

class MainClass
{
    static void Main()
    {
        MeDelegate del = new MeDelegate(Foo);  //can also be written as  MeDelegate del = Foo;  

        del();          //syntactic sugar -> del.Invoke();  
                        //Compiler lets us treat 'del' as a method but it is actually a reference

        MeDelegate d = Foo;
        Console.WriteLine(d.Method);  //Method invoked by delegate d
        Console.WriteLine(d.Target);  //object on which method is invoked by delegate d

        Console.Read();
    }

    static void Foo()
    {
        Console.WriteLine("Foo()");
    }
}