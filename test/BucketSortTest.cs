using GrowingWithTheWeb.Sorting;

public class BucketSortTest : BaseSortTest
{
    protected override void sort(int[] array) {
        var algorithm = new BucketSort();
        algorithm.sort(array);
    }
}