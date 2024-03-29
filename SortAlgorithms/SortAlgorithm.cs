﻿using System;

namespace SortAlgorithms
{
    public abstract class SortAlgorithm<T> 
        where T : IComparable<T>
    {
        public abstract void Sort(T[] array);

        protected static void Swap(T[] array, int i, int j)
        {
            var tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}