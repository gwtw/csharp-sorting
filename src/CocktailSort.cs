using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class CocktailSort : IGenericSortingAlgorithm
    {
        public void Sort<T>(IList<T> list) where T : IComparable
        {
            int start = -1;
            int end = list.Count - 2;
            bool swapped;
            
            do {
                swapped = false;
                for (int i = ++start; i <= end; i++) {
                    if (list[i].CompareTo(list[i + 1]) > 0) {
                        Swap(list, i, i + 1);
                        swapped = true;
                    }
                }

                if (!swapped) {
                    break;
                }

                swapped = false;
                for (int i = --end; i >= start; i--) {
                    if (list[i].CompareTo(list[i + 1]) > 0) {
                        Swap(list, i, i + 1);
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        private void Swap<T>(IList<T> list, int a, int b) where T : IComparable
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }
}