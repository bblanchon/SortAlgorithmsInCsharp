using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithms;

namespace SortAlgorithmsTests
{
    [TestClass]
    public class HeapSortTests : SortTestsBase
    {
        public HeapSortTests() 
            : base(new HeapSort<int>())
        {
        }
    }
}
