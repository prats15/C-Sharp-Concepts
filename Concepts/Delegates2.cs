using System;

namespace GeeksForGeeks
{

    delegate void MeDelegate();

    class Geeks
    {
        void foo()
        {
            Console.WriteLine("Fooooooooo");
        }

        static void goo()
        {
            Console.WriteLine("goooooooo");
        }

        public static void Main(String[] args)
        {
            MeDelegate del = new MeDelegate(new Geeks().foo); // can be written as del = new Geeks().foo
            del();
            del = new MeDelegate(goo); //can also be written as del = goo;
            del();
            Console.Read();
        }
    }
}