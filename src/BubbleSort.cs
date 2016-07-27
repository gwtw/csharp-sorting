using System;
using System.Collections.Generic;

namespace GrowingWithTheWeb.Sorting
{
    public class BubbleSort<T> : IGenericSortingAlgorithm<T> where T : IComparable
    {
        public void Sort(IList<T> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 1; j < list.Count - i; j++)
                {
                    if (list[j - 1].CompareTo(list[j]) > 0)
                    {
                        Swap(list, j, j - 1);
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