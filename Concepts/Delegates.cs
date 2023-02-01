// C# program to illustrate the use of Delegates
using System;
namespace GeeksForGeeks
{
    // declare class "Geeks"
    class Geeks
    {

        // Declaring the delegates
        // Here return type and parameter type should
        // be same as the return type and parameter type
        // of the two methods
        // "addnum" and "subnum" are two delegate names
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        // method "sum"
        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        // method "subtract"
        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }

        // Main Method
        public static void Main(String[] args)
        {

            // creating object "obj" of class "Geeks"
            Geeks obj = new Geeks();

            // creating object of delegate, name as "del_obj1"
            // for method "sum" and "del_obj2" for method "subtract" &
            // pass the parameter as the two methods by class object "obj"
            // instantiating the delegates
            addnum del_obj1 = new addnum(obj.sum);
            subnum del_obj2 = new subnum(obj.subtract);

            // pass the values to the methods by delegate object
            del_obj1(100, 40);
            del_obj2(100, 60);

            // These can be written as using
            // "Invoke" method
            // del_obj1.Invoke(100, 40);
            // del_obj2.Invoke(100, 60);
        }
    }
}