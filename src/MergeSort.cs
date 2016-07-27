using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class MergeSort : IGenericSortingAlgorithm
    {
        public void Sort<T>(IList<T> list) where T : IComparable {
            var sorted = InternalSort(list);
            for (var i = 0; i < list.Count; i++) {
                list[i] = sorted[i]; 
            }
        }
        
        public IList<T> InternalSort<T>(IList<T> list) where T : IComparable
        {
            if (list.Count <= 1)
                return list;

            int middle = list.Count / 2;
            IList<T> left = new T[middle];
            IList<T> right = new T[list.Count - middle];

            for (int i = 0; i < left.Count; i++) {
                left[i] = list[i];
            }
            for (int i = 0; i < right.Count; i++) {
                right[i] = list[i + left.Count];
            }

            left = InternalSort(left);
            right = InternalSort(right);

            return Merge(left, right);
        }

        private T[] Merge<T>(IList<T> left, IList<T> right) where T : IComparable {
            T[] result = new T[left.Count + right.Count];
            int leftIndex = 0;
            int rightIndex = 0;
            int resultIndex = 0;
            while (leftIndex < left.Count || rightIndex < right.Count) {
                if (leftIndex < left.Count && rightIndex < right.Count) {
                    if (left[leftIndex].CompareTo(right[rightIndex]) <= 0) {
                        result[resultIndex++] = left[leftIndex++];
                    } else {
                        result[resultIndex++] = right[rightIndex++];
                    }
                } else if (leftIndex < left.Count) {
                    result[resultIndex++] = left[leftIndex++];
                } else if (rightIndex < right.Count) {
                    result[resultIndex++] = right[rightIndex++];
                }
            }
            return result;
        }
    }
}