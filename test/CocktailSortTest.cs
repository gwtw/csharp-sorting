using GrowingWithTheWeb.Sorting;

public class CocktailSortTest : BaseSortTest
{
    protected override void sort(int[] array) {
        var algorithm = new CocktailSort();
        algorithm.sort(array);
    }
}