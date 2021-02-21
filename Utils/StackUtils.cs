using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4.Utils
{
    public class StackUtils
    {
        private static Random rand = new Random();

        public static Stack<int> GetStackValues(Stack<int> stack1, Stack<int> stack2)
        {
            var newList = stack1.Distinct().Concat(stack2.Distinct()).ToList();
            var query = newList.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToList();
            Stack<int> stack3 = new Stack<int>(query);
            return stack3;
        }

        public static Stack<int> RandomStackFulfil()
        {
            int start = 0;
            int count = 10;
            int maxValue = 50;
            Stack<int> stack = new Stack<int>(Enumerable.Range(start, count)
                .Select(x => rand.Next(maxValue)).OrderByDescending(x => x).ToList());
            return stack;
        }

        public static void ShowStack(Stack<int> stack)
        {
            if (stack.Count != 0)
            {
                foreach (int i in stack)
                {
                    Console.WriteLine($"Item of the 3rd one: {i}");
                }
            }
            else
            {
                Console.WriteLine("No matches in the 1st and 2nd stacks");
            }
        }
    }
}