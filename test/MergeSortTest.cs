using GrowingWithTheWeb.Sorting;

public class MergeSortTest : BaseGenericSortingAlgorithmTest
{
    public MergeSortTest() : base(
            new MergeSort<char>(),
            new MergeSort<string>(),
            new MergeSort<int>()) {
    }
}