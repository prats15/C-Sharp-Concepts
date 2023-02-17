using System;

public delegate void MeDelegate();

class MainClass
{
    static void Main()
    {
        MeDelegate del = Foo;
        InvokeDelegate(del);

        Console.Read();
    }

    static void InvokeDelegate(Delegate del) //Generic Input
    {
        MeDelegate delNew = (MeDelegate)del;
        delNew();
    }

    static void Foo()
    {
        Console.WriteLine("Foo()");
    }
}