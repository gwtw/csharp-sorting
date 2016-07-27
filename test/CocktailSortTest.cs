using GrowingWithTheWeb.Sorting;

public class CocktailSortTest : BaseGenericSortingAlgorithmTest
{
    public CocktailSortTest() : base(
            new CocktailSort<char>(),
            new CocktailSort<string>(),
            new CocktailSort<int>()) {
    }
}