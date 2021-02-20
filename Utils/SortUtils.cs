using System;

namespace Lesson4.Utils
{
    public class SortUtils
    {
        public static int[] GetRandomArray(int length, int minValue, int maxValue)
        {
            var r = new Random();
            var outputArray = new int[length];
            for (var i = 0; i < outputArray.Length; i++)
            {
                outputArray[i] = r.Next(minValue, maxValue);
            }

            return outputArray;
        }
        
        public static void Swap(ref int value1, ref int value2)
        {
            var temp = value1;
            value1 = value2;
            value2 = temp;
        }

        public static void ShowArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}