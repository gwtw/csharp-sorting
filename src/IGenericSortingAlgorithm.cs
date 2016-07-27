using System;
using System.Collections.Generic;

public interface IGenericSortingAlgorithm {
    void sort<T>(IList<T> array) where T : IComparable;
}
