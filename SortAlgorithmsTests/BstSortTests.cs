using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithms;

namespace SortAlgorithmsTests
{
    [TestClass]
    public class BstSortTests : SortTestsBase
    {
        public BstSortTests() 
            : base(new BstSort<int>())
        {
        }
    }
}
