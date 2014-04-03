using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithms;

namespace SortAlgorithmsTests
{
    [TestClass]
    public class MergeSortTests : SortTestsBase
    {
        public MergeSortTests() 
            : base(new MergeSort<int>())
        {
        }
    }
}
