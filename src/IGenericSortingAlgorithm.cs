using System;
using System.Collections.Generic;

public interface IGenericSortingAlgorithm<T> where T : IComparable {
    void Sort(IList<T> list);
}
