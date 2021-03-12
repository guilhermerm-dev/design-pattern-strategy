using System;
using System.Collections.Generic;
using design_pattern_strategy.strategy;

namespace design_pattern_strategy.concrete
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Merge Sort");
        }
    }
}