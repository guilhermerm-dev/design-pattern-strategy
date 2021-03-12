using System;
using System.Collections.Generic;
using design_pattern_strategy.strategy;

namespace design_pattern_strategy.concrete
{
    public class BubbleSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Bubble Sort");
            list.ForEach(item => Console.WriteLine($"{item}"));
        }
    }
}