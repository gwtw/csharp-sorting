using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class CombSort<T> : IGenericSortingAlgorithm<T> where T : IComparable
    {
        public void Sort(IList<T> list)
        {
            int gap = list.Count;
            float shrinkFactor = 1.3f;
            bool swapped = false;

            while (gap > 1 || swapped) {
                if (gap > 1) {
                    gap = (int)(gap / shrinkFactor);
                }

                swapped = false;

                for (int i = 0; gap + i < list.Count; i++) {
                    if (list[i].CompareTo(list[i + gap]) > 0) {
                        Swap(list, i, i + gap);
                        swapped = true;
                    }
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