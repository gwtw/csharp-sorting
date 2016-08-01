namespace GrowingWithTheWeb.Sorting
{
    public class QuicksortRandomPartitionTest : BaseGenericSortingAlgorithmTest
    {
        public QuicksortRandomPartitionTest() : base(
                new Quicksort<char>(true),
                new Quicksort<string>(true),
                new Quicksort<int>(true)) {
        }
    }

    public class QuicksortRightPartitionTest : BaseGenericSortingAlgorithmTest
    {
        public QuicksortRightPartitionTest() : base(
                new Quicksort<char>(false),
                new Quicksort<string>(false),
                new Quicksort<int>(false)) {
        }
    }
}