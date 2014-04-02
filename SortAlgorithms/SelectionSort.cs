using System;

namespace SortAlgorithms
{
    public class SelectionSort<T> : SortAlgorithm<T>
        where T : IComparable<T>
    {
        public override void Sort(T[] array)
        {
            var n = array.Length;

            for (var i = 0; i < n; i++)
            {
                var min = array[i];
                var minIndex = i;

                for (var j = i + 1; j < n; j++)
                {
                    if (array[j].CompareTo(min) < 0)
                    {
                        min = array[j];
                        minIndex = j;
                    }
                }

                Swap(array, i, minIndex);
            }
        }
    }
}
