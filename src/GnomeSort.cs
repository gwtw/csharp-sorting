using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class GnomeSort : IGenericSortingAlgorithm
    {
        public void sort<T>(IList<T> list) where T : IComparable
        {
            int i = 0;
            while (i < list.Count) {
                if (i == 0 || list[i - 1].CompareTo(list[i]) <= 0) {
                    i++;
                } else {
                    swap(list, i, i - 1);
                    i--;
                }
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