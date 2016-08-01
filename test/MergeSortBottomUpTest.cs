namespace GrowingWithTheWeb.Sorting
{
    public class MergeSortBottomUpTest : BaseGenericSortingAlgorithmTest
    {
        public MergeSortBottomUpTest() : base(
                new MergeSortBottomUp<char>(),
                new MergeSortBottomUp<string>(),
                new MergeSortBottomUp<int>()) {
        }
    }
}