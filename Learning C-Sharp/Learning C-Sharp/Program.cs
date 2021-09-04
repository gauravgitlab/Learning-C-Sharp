using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Learning_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130 };

            List<int> result = GetValuesUsingList(collection);
            for (int i = 0; i < result.Count; i++)
                Console.WriteLine(result[i]);
        }

        public static List<int> GetValuesUsingList(List<int> collection)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] > 100)
                    result.Add(collection[i]);
            }

            return result;
        }

    }
}
