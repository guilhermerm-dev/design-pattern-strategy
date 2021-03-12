
using design_pattern_strategy.concrete;

namespace design_pattern_strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var bubbleSortStrategy = new BubbleSort();
            SortedList sortedList1 = new SortedList(bubbleSortStrategy);
            sortedList1.AddItem("item 1");
            sortedList1.AddItem("item 2");
            sortedList1.AddItem("item 3");
            sortedList1.Sort();

            var mergeSortStrategy = new MergeSort();
            SortedList sortedList2 = new SortedList(mergeSortStrategy);
            sortedList2.AddItem("item 1");
            sortedList2.AddItem("item 2");
            sortedList2.AddItem("item 3");
            sortedList2.Sort();

            var shellSortStrategy = new ShellSort();
            SortedList sortedList3 = new SortedList(shellSortStrategy);
            sortedList3.AddItem("item 1");
            sortedList3.AddItem("item 2");
            sortedList3.AddItem("item 3");
            sortedList3.Sort();


        }
    }
}
