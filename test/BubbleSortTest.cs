using GrowingWithTheWeb.Sorting;

public class BubbleSortTest : BaseGenericSortingAlgorithmTest
{
    public BubbleSortTest() : base(
            new BubbleSort<char>(),
            new BubbleSort<string>(),
            new BubbleSort<int>()) {
    }
}