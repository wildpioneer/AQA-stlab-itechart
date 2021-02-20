namespace Lesson4.Utils.Sorts
{
    public class CombSort
    {
        private static int GetNextStep(int s)
        {
            s = s * 1000 / 1247;
            return s > 1 ? s : 1;
        }

        public static int[] DoSort(int[] array)
        {
            var arrayLength = array.Length;
            var currentStep = arrayLength - 1;

            while (currentStep > 1)
            {
                for (int i = 0; i + currentStep < array.Length; i++)
                {
                    if (array[i] > array[i + currentStep])
                    {
                        SortUtils.Swap(ref array[i], ref array[i + currentStep]);
                    }
                }

                currentStep = GetNextStep(currentStep);
            }

            for (var i = 1; i < arrayLength; i++)
            {
                var swapFlag = false;
                for (var j = 0; j < arrayLength - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        SortUtils.Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }

            return array;
        }
    }
}