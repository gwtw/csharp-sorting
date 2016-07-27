using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class InsertionSort : IGenericSortingAlgorithm
    {
        public void sort<T>(IList<T> array) where T : IComparable
        {
            for (int i = 1; i < array.Count; i++) {
                T item = array[i];
                int indexHole = i;
                while (indexHole > 0 && array[indexHole - 1].CompareTo(item) > 0) {
                    array[indexHole] = array[--indexHole];
                }
                array[indexHole] = item;
            }
        }

        private void swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}