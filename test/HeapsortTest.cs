using GrowingWithTheWeb.Sorting;

public class HeapsortTest : BaseGenericSortingAlgorithmTest
{
    public HeapsortTest() : base(
            new Heapsort<char>(),
            new Heapsort<string>(),
            new Heapsort<int>()) {
    }
}