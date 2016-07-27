using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class SelectionSort<T> : IGenericSortingAlgorithm<T> where T : IComparable
    {
        public void Sort(IList<T> list)
        {
            for (int i = 0; i < list.Count - 1; i++) {
                int minIndex = i;
                for (int j = i + 1; j < list.Count; j++) {
                    if (list[j].CompareTo(list[minIndex]) < 0) {
                        minIndex = j;
                    }
                }
                if (minIndex != i) {
                    Swap(list, i, minIndex);
                }
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