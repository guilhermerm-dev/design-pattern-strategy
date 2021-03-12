using System;
using System.Collections.Generic;
using design_pattern_strategy.strategy;

namespace design_pattern_strategy
{
    public class SortedList
    {
        private readonly List<string> _list;
        public SortStrategy SortStrategy { get; private set; }

        public SortedList(SortStrategy sortStrategy)
        {
            SortStrategy = sortStrategy;
            _list = new List<string>();
        }

        public void AddItem(string item)
        {
            this._list.Add(item);
        }

        public void Sort()
        {
            SortStrategy.Sort(_list);
        }

    }
}