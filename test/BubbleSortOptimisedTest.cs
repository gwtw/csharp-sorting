using GrowingWithTheWeb.Sorting;

public class BubbleSortOptimisedTest : BaseSortTest
{
    protected override void sort(int[] array) {
        var algorithm = new BubbleSortOptimised();
        algorithm.sort(array);
    }
}