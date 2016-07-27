using GrowingWithTheWeb.Sorting;

public class SelectionSortTest : BaseGenericSortingAlgorithmTest
{
    public SelectionSortTest() : base(
            new SelectionSort<char>(),
            new SelectionSort<string>(),
            new SelectionSort<int>()) {
    }
}