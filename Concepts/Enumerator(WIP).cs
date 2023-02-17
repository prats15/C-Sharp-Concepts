using System;
using System.Collections;
using System.Collections.Generic;

namespace GeeksForGeeks
{
    static class MyClass
    {
        public static void Main()
        {
            //int[] array = new int[] { 1, 2, 3 };
            var enumeratable = new GetInfinityEnumeratable();

            //var enumerator = enumeratable.GetEnumerator();

            foreach (int i in enumeratable)
            {
                Console.WriteLine(i);
            }


            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}

            Console.Read();
        }
    }

    public class GetInfinityEnumeratable : IEnumerable<int>
    {
        private int[] arr = new int[] { 1, 2, 3};

        public IEnumerator<int> GetEnumerator()
        {
            return new GetInfinityEnumerator(arr);
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return new GetInfinityEnumerator(arr);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new GetInfinityEnumerator(arr);
        }
    }

    public class GetInfinityEnumerator : IEnumerator<int>
    {
        private int[] array;
        private int index = -1;

        public GetInfinityEnumerator(int[] arr)
        {
            this.array = arr;
        }

        public int Current => array[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            index++;

            return index < array.Length;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
