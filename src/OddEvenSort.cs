using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class OddEvenSort<T> : IGenericSortingAlgorithm<T> where T : IComparable
    {
        public void Sort(IList<T> list)
        {
            var sorted = false;
            while (!sorted) {
                sorted = InnerSort(list, 1);
                sorted = sorted && InnerSort(list, 0);
            }
        }

        private bool InnerSort(IList<T> list, int i)
        {
            var sorted = true;
            for (; i < list.Count - 1; i += 2)
            {
                if (list[i].CompareTo(list[i + 1]) > 0)
                {
                    Swap(list, i, i + 1);
                    sorted = false;
                }
            }
            return sorted;
        }

        private void Swap(IList<T> list, int a, int b)
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }
}