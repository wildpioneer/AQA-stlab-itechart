using System.Collections.Generic;
using System.Linq;
using Lesson4.Utils;

namespace Lesson4.Tasks
{
    public class ThirdTask
    {
        public static void Runner()
        {
            List<int> list = new List<int>();
            ListUtils.FillList(15, list);
            ListUtils.PrintList(list);
            while (list.Count > 1)
            {
                list = new List<int>(list
                    .Where((x, i) => i % 2 == 0)
                    .OrderBy(el => list));
                ListUtils.PrintList(list);
            }
        }
    }
}