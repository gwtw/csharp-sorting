using GrowingWithTheWeb.Sorting;

public class InsertionSortTest : BaseGenericSortingAlgorithmTest
{
    public InsertionSortTest() : base(
            new InsertionSort<char>(),
            new InsertionSort<string>(),
            new InsertionSort<int>()) {
    }
}