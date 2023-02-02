using System;
using System.Reflection;

namespace MySpace
{
    class Cow
    {
        public int mooCount;
    }

    static class cowExtensionMethod
    {
        public static void Moo(this Cow cow)
        {
            cow.mooCount++;
            Console.WriteLine("Mooo " + cow.mooCount);
        }
    }

    class MainClass
    {
        public static void Main()
        {
            Cow c1 = new Cow();
            c1.Moo(); c1.Moo(); c1.Moo();
            Console.Read();
        }
    }
}