using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class CombSort : IGenericSortingAlgorithm
    {
        public void Sort<T>(IList<T> list) where T : IComparable
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

        private void Swap<T>(IList<T> list, int a, int b) where T : IComparable
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }
}