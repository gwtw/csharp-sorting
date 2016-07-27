using GrowingWithTheWeb.Sorting;

public class HeapSortTest : BaseGenericSortingAlgorithmTest
{
    public HeapSortTest() : base(
            new HeapSort<char>(),
            new HeapSort<string>(),
            new HeapSort<int>()) {
    }
}