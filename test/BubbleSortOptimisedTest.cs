namespace GrowingWithTheWeb.Sorting
{
    public class BubbleSortOptimisedTest : BaseGenericSortingAlgorithmTest
    {
        public BubbleSortOptimisedTest() : base(
                new BubbleSortOptimised<char>(),
                new BubbleSortOptimised<string>(),
                new BubbleSortOptimised<int>()) {
        }
    }
}