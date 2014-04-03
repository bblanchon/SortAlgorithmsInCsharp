using System;

namespace SortAlgorithms
{
    public class MergeSort<T> : SortAlgorithm<T>
        where T : IComparable<T>
    {
        T[] array;
        T[] buffer;

        public override void Sort(T[] a)
        {
            var n = a.Length;

            array = a;
            buffer = new T[n];

            SortRange(0, n);
        }

        void SortRange(int left, int right)
        {
            if (right - left <= 1) return;

            var middle = (left + right) / 2;

            SortRange(left, middle);
            SortRange(middle, right);
            MergeRanges(left, middle, right);
        }

        void MergeRanges(int left, int middle, int right)
        {
            Array.Copy(array, left, buffer, left, right-left);

            var writeCursor = left;
            var leftCursor = left;
            var rightCursor = middle;

            while (leftCursor < middle && rightCursor < right)
            {
                if (buffer[leftCursor].CompareTo(buffer[rightCursor]) <= 0)
                {
                    array[writeCursor++] = buffer[leftCursor++];
                }
                else
                {
                    array[writeCursor++] = buffer[rightCursor++];
                }
            }

            while (leftCursor < middle)
            {
                array[writeCursor++] = buffer[leftCursor++];
            }
        }
    }
}
