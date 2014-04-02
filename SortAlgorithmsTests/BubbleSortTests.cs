using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithms;

namespace SortAlgorithmsTests
{
    [TestClass]
    public class BubbleSortTests
    {
        BubbleSort<int> algo;
        Random rand;
        Stopwatch chrono;

        [TestInitialize]
        public void Initialize()
        {
            algo = new BubbleSort<int>();
            rand = new Random();
            chrono = new Stopwatch();
        }

        [TestMethod]
        public void EmptyArray()
        {
            RunTest(/*empty*/);
        }

        [TestMethod]
        public void OneElement()
        {
            RunTest(42);
        }

        [TestMethod]
        public void TwoElementsUnordered()
        {
            RunTest(42, 41);
        }

        [TestMethod]
        public void TwoElementsOrdered()
        {
            RunTest(41, 42);
        }

        [TestMethod]
        public void Random100Elements()
        {
            RunTest(GenerateRandomArray(100));
        }

        [TestMethod]
        public void Random1000Elements()
        {
            RunTest(GenerateRandomArray(1000));
        }

        [TestMethod]
        public void Random10000Elements()
        {
            RunTest(GenerateRandomArray(10000));
        }

        int[] GenerateRandomArray(int length)
        {
            return Enumerable.Range(0, length).Select(x => rand.Next()).ToArray();
        }
        
        void RunTest(params int[] input)
        {
            var expected = input.OrderBy(x => x).ToArray();
            RunAlgorithm(input);
            CollectionAssert.AreEqual(expected, input);
        }

        void RunAlgorithm(int[] input)
        {
            chrono.Start();
            algo.Sort(input);
            chrono.Stop();

            Console.WriteLine("{0} elements sorted in {1} ms", input.Length, chrono.ElapsedMilliseconds);
        }
    }
}
