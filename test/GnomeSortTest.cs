using GrowingWithTheWeb.Sorting;

public class GnomeSortTest : BaseGenericSortingAlgorithmTest
{
    public GnomeSortTest() : base(
            new GnomeSort<char>(),
            new GnomeSort<string>(),
            new GnomeSort<int>()) {
    }
}