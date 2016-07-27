using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class HeapSort : IGenericSortingAlgorithm
    {
        public void sort<T>(IList<T> list) where T : IComparable
        {
            int heapSize = list.Count;
            buildHeap(list, heapSize);
            while (heapSize > 1) {
                swap(list, 0, heapSize - 1);
                heapSize--;
                heapify(list, heapSize, 0);
            }
        }

        private void buildHeap<T>(IList<T> list, int heapSize) where T : IComparable {
            for (int i = (int)(list.Count / 2); i >= 0; i--) {
                heapify(list, heapSize, i);
            }
        }

        private void heapify<T>(IList<T> list, int heapSize, int i) where T : IComparable {
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
                swap(list, i, largest);
                heapify(list, heapSize, largest);
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