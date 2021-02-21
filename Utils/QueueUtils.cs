using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4.Utils
{
    public class QueueUtils
    {
        public static void FindSum(Queue<int> numbers)
        {
            int sum = 0;
            int minInd = Array.IndexOf(numbers.ToArray(), numbers.ToArray().Min());
            int maxInd = Array.IndexOf(numbers.ToArray(), numbers.ToArray().Max());
            if (minInd > maxInd)
            {
                for (int i = maxInd; i <= minInd; i++)
                    sum += numbers.ToArray()[i];
                Console.WriteLine($"Sum is {sum}");
            }
            else
            {
                for (int i = minInd; i <= maxInd; i++)
                    sum += numbers.ToArray()[i];
                Console.WriteLine($"Sum is {sum}");
            }
        }

        public static void QueueFulFil(Queue<int> numbers, int[] array)
        {
            foreach (int i in array)
            {
                numbers.Enqueue(i);
            }
        }
    }
}