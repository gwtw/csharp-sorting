using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class Quicksort<T> : IGenericSortingAlgorithm<T> where T : IComparable
    {
        private Random _random;
        private PartitionDelegate _partitionFunction;

        public delegate int PartitionDelegate(IList<T> list, int left, int right);

        public Quicksort(bool randomPartition) {
            if (randomPartition) {
                _random = new Random();
                _partitionFunction = PartitionRandom;
            } else {
                _partitionFunction = PartitionRight;
            }
        }

        public void Sort(IList<T> list) {
            Sort(list, 0, list.Count - 1);
        }
        
        private void Sort(IList<T> list, int left, int right) {
            if (left < right) {
                int pivot = _partitionFunction(list, left, right);
                Sort(list, left, pivot - 1);
                Sort(list, pivot + 1, right);
            }
        }

        private int PartitionRandom(IList<T> list, int left, int right) {
            int pivot = left + _random.Next(right - left);
            Swap(list, right, pivot);
            return PartitionRight(list, left, right);
        }

        private int PartitionRight(IList<T> list, int left, int right) {
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

        private void Swap(IList<T> list, int a, int b)
        {
            if (a != b) {
                T temp = list[a];
                list[a] = list[b];
                list[b] = temp;
            }
        }
    }
}