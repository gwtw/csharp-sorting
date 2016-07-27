using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class InsertionSort<T> : IGenericSortingAlgorithm<T> where T : IComparable
    {
        public void Sort(IList<T> list)
        {
            for (int i = 1; i < list.Count; i++) {
                T item = list[i];
                int indexHole = i;
                while (indexHole > 0 && list[indexHole - 1].CompareTo(item) > 0) {
                    list[indexHole] = list[--indexHole];
                }
                list[indexHole] = item;
            }
        }
    }
}