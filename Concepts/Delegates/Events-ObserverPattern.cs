using System;
using System.Collections.Generic;


class TrainSignal
{
    public Action TrainIsComing;
    public void HereComesATrain()
    {
        //tons of logic
        TrainIsComing();
    }
}

class Car
{
    public Car(TrainSignal trainSignal)
    {
        trainSignal.TrainIsComing += StopTheCar;  //Observer pattern -> this instance of car suscribes the trainSignal
    }                                             //car is sort of observing the trainSignal, whenever HereComesATrain
    void StopTheCar()                             //is invoked, every car get a stop msg via StopTheCar method.     
    {
        Console.WriteLine("Stopppppp");
    }
}


class MainClass
{
    static void Main()
    {
        TrainSignal trainSignal = new TrainSignal();

        new Car(trainSignal);       //these 4 cars have subscribed to TrainSignal
        new Car(trainSignal);       //when code is going through these statements, ctor of car is called and 
        new Car(trainSignal);       //StopTheCar method is attached to TrainIsComing action, 4 times
        new Car(trainSignal);       //InvokationList -> TrainIsComing + StopTheCar + StopTheCar + StopTheCar

        trainSignal.HereComesATrain();
        Console.WriteLine();
        trainSignal.HereComesATrain();
        Console.WriteLine();
        trainSignal.HereComesATrain();

        Console.Read();
    }
}
