namespace GrowingWithTheWeb.Sorting
{
    public class CombSortTest : BaseGenericSortingAlgorithmTest
    {
        public CombSortTest() : base(
                new CombSort<char>(),
                new CombSort<string>(),
                new CombSort<int>()) {
        }
    }
}