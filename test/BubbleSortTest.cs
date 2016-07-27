using GrowingWithTheWeb.Sorting;
using Xunit;

public class BubbleSortTest
{
    [Fact]
    public void PassingTest()
    {
        var algorithm = new BubbleSort();
        var result = new int[] {2, 1};
        algorithm.sort(result);
        Assert.Equal(new int[] {1, 2}, result);
    }
}