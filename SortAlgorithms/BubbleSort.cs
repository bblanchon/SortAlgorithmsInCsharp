using System;

namespace SortAlgorithms
{
    public class BubbleSort<T> : SortAlgorithm<T>
        where T : IComparable<T>
    {
        public override void Sort(T[] array)
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

        protected static void SwapIfNeeded(T[] array, int i, int j)
        {
            if (array[i].CompareTo(array[j]) <= 0) return;
            Swap(array, i, j);
        }
    }
}
