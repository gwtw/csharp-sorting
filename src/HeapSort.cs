using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class HeapSort : IGenericSortingAlgorithm
    {
        public void Sort<T>(IList<T> list) where T : IComparable
        {
            int heapSize = list.Count;
            BuildHeap(list, heapSize);
            while (heapSize > 1) {
                Swap(list, 0, heapSize - 1);
                heapSize--;
                Heapify(list, heapSize, 0);
            }
        }

        private void BuildHeap<T>(IList<T> list, int heapSize) where T : IComparable {
            for (int i = (int)(list.Count / 2); i >= 0; i--) {
                Heapify(list, heapSize, i);
            }
        }

        private void Heapify<T>(IList<T> list, int heapSize, int i) where T : IComparable {
            int left = i * 2 + 1;
            int right = i * 2 + 2;
            int largest;
            if (left < heapSize && list[left].CompareTo(list[i]) > 0)
                largest = left;
            else
                largest = i;
            if (right < heapSize && list[right].CompareTo(list[largest]) > 0)
                largest = right;
            if (largest != i) {
                Swap(list, i, largest);
                Heapify(list, heapSize, largest);
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