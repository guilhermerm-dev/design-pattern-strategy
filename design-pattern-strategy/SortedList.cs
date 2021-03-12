using System;
using System.Collections.Generic;
using design_pattern_strategy.strategy;

namespace design_pattern_strategy
{
    public class SortedList
    {
        private readonly List<string> _list;
        private readonly SortStrategy _sortStrategy;

        public SortedList(SortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
            _list = new List<string>();
        }

        public void AddItem(string item)
        {
            this._list.Add(item);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);

            _list.ForEach(item => Console.WriteLine("${item}"));
        }

    }
}