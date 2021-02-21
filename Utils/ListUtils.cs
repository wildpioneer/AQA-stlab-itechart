using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4.Utils
{
    public class ListUtils
    {
        private static Random rand = new Random();

        public static void PrintList(List<Int32> list)
        {
            foreach (var item in list)
                Console.Write("{0} ", item);
            Console.WriteLine();
        }

        public static void FillList(int n, List<int> list)
        {
            for (int i = 0; i < n; i++)
            {
                list.Add(i + 1);
            }
        }

        public static ArrayList RandomFulfil()
        {
            int start = 0;
            int count = 10;
            int maxValue = 50;
            ArrayList list = new ArrayList(Enumerable.Range(start, count)
                .Select(x => rand.Next(maxValue)).OrderByDescending(x => x).ToList());
            return list;
        }
    }
}