using GrowingWithTheWeb.Sorting;

public class InsertionSortTest : BaseSortTest
{
    protected override void sort(int[] array) {
        var algorithm = new InsertionSort();
        algorithm.sort(array);
    }
}