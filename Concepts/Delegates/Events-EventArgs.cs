using System;
using System.Collections.Generic;

public enum CowState
{
    Awake, 
    Sleeping, 
    Dead
}

class CowStateEventArgs : EventArgs
{
    public CowState currentCowState { get; private set; }

    public CowStateEventArgs(CowState state)
    {
        currentCowState = state;
    }
}

class Cow
{
    public string Name;
    public event EventHandler<CowStateEventArgs> Moo;  

    public void PushTheCow()
    {
        if (Moo != null)
            Moo(this, new CowStateEventArgs(CowState.Awake));
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

    static void CowHandler(object sender, CowStateEventArgs e)
    {
        Cow c = sender as Cow;
        Console.WriteLine("CowHandler called for - {0}", c.Name);
        switch(e.currentCowState)
        {
            case CowState.Awake:
                Console.WriteLine("{0} is awake", c.Name);
                break;
            case CowState.Sleeping:
                Console.WriteLine("{0} is Sleeping", c.Name);
                break;
            case CowState.Dead:
                Console.WriteLine("{0} is Dead", c.Name);
                break;
        }
    }
}
