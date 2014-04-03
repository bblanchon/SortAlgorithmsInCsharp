using System;

namespace SortAlgorithms
{
    public class QuickSort<T> : SortAlgorithm<T>
        where T : IComparable<T>
    {
        T[] array;

        public override void Sort(T[] a)
        {
            array = a;
            SortRange(0, a.Length);
        }

        void SortRange(int left, int right)
        {
            if (right - left <= 1) return;

            var pivotIndex = Partition(left, right);
            SortRange(left, pivotIndex);
            SortRange(pivotIndex+1, right);
        }

        int Partition(int left, int right)
        {
            var pivotIndex = right - 1;
            var pivotValue = array[pivotIndex];
            var writeCursor = left;

            for (var i = left; i < right; i++)
            {
                var valueIsSmall = pivotValue.CompareTo(array[i]) > 0;

                if (valueIsSmall)
                {
                    Swap(array, i, writeCursor++);
                }
            }

            Swap(array, writeCursor, pivotIndex);

            return writeCursor;
        }
    }
}
