using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithms;

namespace SortAlgorithmsTests
{
    [TestClass]
    public class QuickSortTests : SortTestsBase
    {
        public QuickSortTests() 
            : base(new QuickSort<int>())
        {
        }
    }
}
