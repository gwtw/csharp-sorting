using GrowingWithTheWeb.Sorting;

public class BubbleSortTest : BaseSortTest
{
    protected override void sort(int[] array) {
        var algorithm = new BubbleSort();
        algorithm.sort(array);
    }
}