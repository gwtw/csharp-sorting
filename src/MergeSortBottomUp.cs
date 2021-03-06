using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class MergeSortBottomUp<T> : IGenericSortingAlgorithm<T> where T : IComparable
    {
        public void Sort(IList<T> list) {
            IList<T> workList = new T[list.Count];
            int chunkSize = 1;
            while (chunkSize < list.Count) {
                int i = 0;
                while (i < list.Count - chunkSize) {
                    Merge(list, i, chunkSize, workList);
                    i += chunkSize * 2;
                }
                chunkSize *= 2;
            }
        }

        private void Merge(IList<T> list, int leftPosition, int chunkSize, IList<T> workList) {
            int rightPosition = leftPosition + chunkSize;
            int endPosition = Math.Min(leftPosition + chunkSize * 2 - 1, list.Count - 1);
            int leftIndex = leftPosition;
            int rightIndex = rightPosition;

            for (int i = 0; i <= endPosition - leftPosition; i++) {
                if (leftIndex < rightPosition &&
                        (rightIndex > endPosition ||
                        list[leftIndex].CompareTo(list[rightIndex]) <= 0)) {
                    workList[i] = list[leftIndex++];
                } else {
                    workList[i] = list[rightIndex++];
                }
            }

            for (int i = leftPosition; i <= endPosition; i++) {
                list[i] = workList[i - leftPosition];
            }
        }
    }
}