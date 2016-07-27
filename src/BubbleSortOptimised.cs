using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class BubbleSortOptimised : IGenericSortingAlgorithm
    {
        public void sort<T>(IList<T> list) where T : IComparable
        {
            int unsortedBelow = list.Count;
            while (unsortedBelow != 0) {
                int lastSwap = 0;
                for (int i = 1; i < unsortedBelow; i++) {
                    if (list[i - 1].CompareTo(list[i]) > 0) {
                        swap(list, i, i - 1);
                        lastSwap = i;
                    }
                }
                unsortedBelow = lastSwap;
            }
        }

        private void swap<T>(IList<T> list, int a, int b) where T : IComparable
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }
}