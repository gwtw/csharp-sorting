using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class InsertionSort : IGenericSortingAlgorithm
    {
        public void Sort<T>(IList<T> list) where T : IComparable
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