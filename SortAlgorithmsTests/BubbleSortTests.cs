﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithms;

namespace SortAlgorithmsTests
{
    [TestClass]
    public class BubbleSortTests : SortTestsBase
    {
        public BubbleSortTests() 
            : base(new BubbleSort<int>())
        {
        }
    }
}
