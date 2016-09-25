namespace GrowingWithTheWeb.Sorting
{
    public class OddEvenSortTest : BaseGenericSortingAlgorithmTest
    {
        public OddEvenSortTest() : base(
                new OddEvenSort<char>(),
                new OddEvenSort<string>(),
                new OddEvenSort<int>()) {
        }
    }
}