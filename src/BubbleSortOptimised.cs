using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class BubbleSortOptimised<T> : IGenericSortingAlgorithm<T> where T : IComparable
    {
        public void Sort(IList<T> list)
        {
            int unsortedBelow = list.Count;
            while (unsortedBelow != 0) {
                int lastSwap = 0;
                for (int i = 1; i < unsortedBelow; i++) {
                    if (list[i - 1].CompareTo(list[i]) > 0) {
                        Swap(list, i, i - 1);
                        lastSwap = i;
                    }
                }
                unsortedBelow = lastSwap;
            }
        }

        private void Swap(IList<T> list, int a, int b)
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }
}