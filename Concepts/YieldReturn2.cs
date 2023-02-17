using System;
using System.Collections;
using System.Collections.Generic;

//when yield return is used in a method, compiler creates a class with name (similar) to the method name and 
//implements IEnumerable<>, IEnumerable, IEnumerator<>, IEnumerator. That class is itself aIEnumerable and IEnumerator.

class MeList<T>
{
    T[] items = new T[5];
    int count;
    public void Add(T item)
    {
        if (count == items.Length)
            Array.Resize(ref items, items.Length * 2);
        items[count++] = item;
    }

    public IEnumerator<T> GetEnumerator()  //if the return type is IEnumerable<T>, then in the foreach loop in MainClass
    {                                      //will be -> foreach (int i in ages.GetEnumerator()) 
        for (int i = 0; i < count; i++)    //if the return type is IEnumerator<T>, then in the foreach loop in MainClass
            yield return items[i];         //will be -> foreach (int i in ages) 
    }
}

class MainClass
{
    static void Main()
    {
        MeList<int> ages = new MeList<int>();
        ages.Add(25);
        ages.Add(35);
        ages.Add(45);
        ages.Add(55);

        foreach (int i in ages)        //Since 'ages' which is of MeList type -> is not IEnumerable, 
        {                              //we explicitly have to define GetEnumerator method in MeList class
            Console.WriteLine(i);
        }

        Console.Read();
    }
}