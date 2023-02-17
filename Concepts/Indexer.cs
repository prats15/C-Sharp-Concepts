using System;
using System.Collections;
using System.Collections.Generic;

class MeList<T> : IEnumerable<T>
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

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public T this[int index]                //indexer is just like a property which takes index as argument
    {
        get
        {
            if (index >= count || index < 0)
                throw new IndexOutOfRangeException();
            return items[index];
        }
        set
        {
            if (index >= count || index < 0)
                throw new IndexOutOfRangeException();
            items[index] = value;
        }
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

        MeList<int> sampleList = new MeList<int>() 
        { 25,                   //if object initializer syntax is used to initialize list, 
          35,                   //then the list type (MeList) must be IEnumerable
          45,                   //foreach works even if MeList is not IEnumerable, foreach only needs GetEnumerator method
          55 };                 //in the MeList class

        //in List datatype, you can access any element of that list can be accessed using index just like an array
        //eg. List<int> meList = new List<int>() {1,2,3,4};
        // Console.WriteLine(meList[2]);
        //This is because, indexer is defined in List class. 

        Console.WriteLine("------------- Indexer output -----------");
        Console.WriteLine(sampleList[2]); //should return 45, need to add indexer in MeList class for this to work
                                                                           

        Console.Read();
    }
}