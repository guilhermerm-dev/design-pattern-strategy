using design_pattern_strategy;
using design_pattern_strategy.concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace design_pattern_strategy_tests
{
    [TestClass]
    public class SortStrategyTest
    {
        [TestMethod]
        public void SortedList_Strategy_Should_Be_BubbleSort()
        {
            var bubbleSortStrategy = new BubbleSort();
            SortedList sortedList = new SortedList(bubbleSortStrategy);
            Assert.AreEqual(sortedList.SortStrategy.GetType(), typeof(BubbleSort));
        }

        [TestMethod]
        public void SortedList_Strategy_Should_Be_MergeSort()
        {
            var mergeSortStrategy = new MergeSort();
            SortedList sortedList = new SortedList(mergeSortStrategy);
            Assert.AreEqual(sortedList.SortStrategy.GetType(), typeof(MergeSort));
            Assert.AreEqual(sortedList.SortStrategy.GetType(), typeof(MergeSort));
        }

        [TestMethod]
        public void SortedList_Strategy_Should_Be_ShellSort()
        {
            var shellSortStrategy = new ShellSort();
            SortedList sortedList = new SortedList(shellSortStrategy);
            Assert.AreEqual(sortedList.SortStrategy.GetType(), typeof(ShellSort));
        }
    }
}
