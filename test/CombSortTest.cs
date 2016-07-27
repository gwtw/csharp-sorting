using GrowingWithTheWeb.Sorting;

public class CombSortTest : BaseSortTest
{
    protected override void sort(int[] array) {
        var algorithm = new CombSort();
        algorithm.sort(array);
    }
}