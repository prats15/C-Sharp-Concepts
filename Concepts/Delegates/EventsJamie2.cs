using System;
using System.Collections.Generic;

//Difference between Delegates and Eventss -> 
//Events are just delegates with 2 restrictions. 1. Events cannot be invoked directly (except in the class they're declared in)
//2. Value cannot be assigned to events directly. You can only do +=/-= on events. 

class Cow
{
    public event Action Moo;  //this creates private Action Moo and public event Action Moo

    public void PushTheCow()
    {
        Moo();
    }
}

class MainClass
{
    static void Main()
    {
        Cow Betsy = new Cow();
        Betsy.Moo += () => Console.WriteLine("Betsy is Mooing"); //Any method that subscribes to the event is called Handler
                                                                 //Lambda exp (method) in this case
        Betsy.PushTheCow();

        Console.Read();
    }
}
