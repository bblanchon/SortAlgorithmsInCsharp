using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class HeapSort<T> : SortAlgorithm<T>
        where T : IComparable<T>
    {
        public override void Sort(T[] array)
        {
            var heap = new Heap();

            foreach (var value in array)
            {
                heap.Add(value);
            }

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = heap.RemoveMin();
            }
        }

        class Heap
        {
            readonly List<T> nodes = new List<T>();

            public void Add(T value)
            {
                var nodeIndex = nodes.Count;
                nodes.Add(value);
                BubbleUp(nodeIndex);
            }

            public T RemoveMin()
            {
                if (nodes.Count == 0)
                    throw new InvalidOperationException("Heap is empty");

                var value = nodes[0];

                var lastIndex = nodes.Count - 1;
                nodes[0] = nodes[lastIndex];
                nodes.RemoveAt(lastIndex);

                BubbleDown(0);

                return value;
            }

            void BubbleDown(int nodeIndex)
            {
                if (!HasChildren(nodeIndex)) return;
                
                var nodeValue = nodes[nodeIndex];
                var smallestChildIndex = GetSmallestChild(nodeIndex);
                var smallestChildValue = nodes[smallestChildIndex];

                if (smallestChildValue.CompareTo(nodeValue) < 0)
                {
                    Swap(nodeIndex, smallestChildIndex);
                    BubbleDown(smallestChildIndex);
                }
            }

            bool HasChildren(int parentIndex)
            {
                return GetLeftChildIndex(parentIndex) < nodes.Count;
            }

            int GetSmallestChild(int parentIndex)
            {
                var leftChildIndex = GetLeftChildIndex(parentIndex);
                var leftChildValue = nodes[leftChildIndex];

                var rightChildIndex = GetRightChildIndex(parentIndex);

                if (rightChildIndex >= nodes.Count)
                    return leftChildIndex;
                
                var rightChildValue = nodes[rightChildIndex];
                return rightChildValue.CompareTo(leftChildValue) < 0 ? rightChildIndex : leftChildIndex;
            }

            void BubbleUp(int nodeIndex)
            {
                if (nodeIndex == 0) return;

                var parentIndex = GetParentIndex(nodeIndex);

                var nodeValue = nodes[nodeIndex];
                var parentValue = nodes[parentIndex];

                if (nodeValue.CompareTo(parentValue) > 0) return;
                
                Swap(nodeIndex, parentIndex);
                BubbleUp(parentIndex);
            }
            
            void Swap(int nodeIndex1, int nodeIndex2)
            {
                var tmp = nodes[nodeIndex1];
                nodes[nodeIndex1] = nodes[nodeIndex2];
                nodes[nodeIndex2] = tmp;
            }

            static int GetParentIndex(int childIndex)
            {
                return (childIndex - 1)/2;
            }

            static int GetLeftChildIndex(int parentIndex)
            {
                return parentIndex*2 + 1;
            }

            static int GetRightChildIndex(int parentIndex)
            {
                return parentIndex*2 + 2;
            }
        }
    }
}
