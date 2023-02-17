using System;
using System.Collections;
using System.Collections.Generic;

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

    public IEnumerator<T> GetEnumerator()
    {
        return new MeEnumerator(this);
    }

    class MeEnumerator : IEnumerator<T>
    {
        int index = -1;
        MeList<T> theList;

        public bool MoveNext()
        {
            index++;
            return index < theList.count;
        }
        public MeEnumerator(MeList<T> theList)
        {
            this.theList = theList;
        }

        public T Current => theList.items[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {

        }

        public void Reset()
        {
            index = -1;
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

        foreach(int i in ages)
        {
            Console.WriteLine(i);
        }

        Console.Read();
    }
}