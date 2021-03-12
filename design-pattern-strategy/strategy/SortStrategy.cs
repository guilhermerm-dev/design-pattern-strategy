using System.Collections.Generic;

namespace design_pattern_strategy.strategy
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}