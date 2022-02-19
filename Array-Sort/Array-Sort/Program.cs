using System;

namespace Array_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 51, 212, 6, 0, 12, -241, -21, 97, 1 };
            Array.Sort(numbers);
            foreach (int index in numbers)
            {
                Console.Write($"{index} ");
            }
        }
    }
}
