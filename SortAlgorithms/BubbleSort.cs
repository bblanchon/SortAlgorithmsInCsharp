using System;

namespace SortAlgorithms
{
    public class BubbleSort<T>
         where T : IComparable<T>
    {
        public void Sort(T[] array)
        {
            var n = array.Length;

            for (var i = 0; i < n; i++)
            {
                for (var j = i; j < n; j++)
                {
                    SwapIfNeeded(array, i, j);
                }
            }
        }

        static void SwapIfNeeded(T[] array, int i, int j)
        {
            if (array[i].CompareTo(array[j]) <= 0) return;
            Swap(array, i, j);
        }

        static void Swap(T[] array, int i, int j)
        {
            var tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}
