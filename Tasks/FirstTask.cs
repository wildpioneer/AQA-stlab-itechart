using System.Collections.Generic;
using Lesson4.Utils;

namespace Lesson4
{
    public class FirstTask
    {
        public static void Runner()
        {
            Stack<int> stack1 = new Stack<int>(StackUtils.RandomStackFulfil());
            Stack<int> stack2 = new Stack<int>(StackUtils.RandomStackFulfil());
            Stack<int> stack3 = StackUtils.GetStackValues(stack1, stack2);
            StackUtils.ShowStack(stack3);
        }
    }
}