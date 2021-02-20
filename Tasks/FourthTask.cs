using Lesson4.Utils;
using Lesson4.Utils.Sorts;

namespace Lesson4.Tasks
{
    public class FourthTask
    {
        public static void Runner()
        {
            var array = SortUtils.GetRandomArray(5, 0, 15);
            SortUtils.ShowArray(array);
            SortUtils.ShowArray(CombSort.DoSort(array));
            
            var array2 = SortUtils.GetRandomArray(5, 0, 15);
            SortUtils.ShowArray(array2);
            SortUtils.ShowArray(ShellSort.DoSort(array2));
        }
    }
}