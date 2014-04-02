using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithms;

namespace SortAlgorithmsTests
{
    [TestClass]
    public class SelectionSortTests : SortTestsBase
    {
        public SelectionSortTests() 
            : base(new SelectionSort<int>())
        {
        }
    }
}
