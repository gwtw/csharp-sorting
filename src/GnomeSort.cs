using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class GnomeSort<T> : IGenericSortingAlgorithm<T> where T : IComparable
    {
        public void Sort(IList<T> list)
        {
            int i = 0;
            while (i < list.Count) {
                if (i == 0 || list[i - 1].CompareTo(list[i]) <= 0) {
                    i++;
                } else {
                    Swap(list, i, i - 1);
                    i--;
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