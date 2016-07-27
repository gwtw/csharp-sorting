using System;
using System.Collections.Generic;

public interface IGenericSortingAlgorithm {
    void Sort<T>(IList<T> array) where T : IComparable;
}
