using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class Quicksort : IGenericSortingAlgorithm
    {
        public void Sort<T>(IList<T> list) where T : IComparable {
            Sort(list, 0, list.Count - 1);
        }
        
        private void Sort<T>(IList<T> list, int left, int right) where T : IComparable {
            if (left < right) {
                int pivot = Partition(list, left, right);
                Sort(list, left, pivot - 1);
                Sort(list, pivot + 1, right);
            }
        }

        private int Partition<T>(IList<T> list, int left, int right) where T : IComparable {
            T pivot = list[right];
            int mid = left;
            for (int i = mid; i < right; i++) {
                if (list[i].CompareTo(pivot) <= 0) {
                    Swap(list, i, mid++);
                }
            }
            Swap(list, right, mid);
            return mid;
        }

        private void Swap<T>(IList<T> list, int a, int b) where T : IComparable
        {
            if (a != b) {
                T temp = list[a];
                list[a] = list[b];
                list[b] = temp;
            }
        }
    }
}