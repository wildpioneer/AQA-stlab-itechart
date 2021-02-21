using System.Collections.Generic;
using Lesson4.Utils;

namespace Lesson4.Tasks
{
    public class SecondTask
    {
        public static void Runner()
        {
            Queue<int> numbers = new Queue<int>();
            int[] array = {5, 1, 6, 3, 4, 9, 8, 7, 2};
            QueueUtils.QueueFulFil(numbers, array);
            QueueUtils.FindSum(numbers);
        }
    }
}