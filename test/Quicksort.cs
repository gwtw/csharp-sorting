using GrowingWithTheWeb.Sorting;

public class QuicksortRandomPartitionTest : BaseGenericSortingAlgorithmTest
{
    public QuicksortRandomPartitionTest() : base(
            new Quicksort<char>(true),
            new Quicksort<string>(true),
            new Quicksort<int>(true)) {
    }
}