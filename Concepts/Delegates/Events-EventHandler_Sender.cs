using System;
using System.Collections.Generic;

class Cow
{
    public string Name;
    public event EventHandler Moo;  //99% of the time EventHandler delegate is used in case of events

    public void PushTheCow()
    {
        if (Moo != null)
            Moo(this, EventArgs.Empty);
    }
}

class MainClass
{
    static void Main()
    {
        Cow c1 = new Cow() { Name = "Betsy"};
        c1.Moo += CowHandler;
        Cow c2 = new Cow() { Name = "Georgy" };
        c2.Moo += CowHandler;
        Cow victim = new Random().Next() % 2 == 0 ? c1 : c2;

        victim.PushTheCow();

        Console.Read();
    }

    static void CowHandler(object sender, EventArgs e)
    {
        Cow c = sender as Cow;
        Console.WriteLine("CowHandler called for - {0}", c.Name);
    }
}
