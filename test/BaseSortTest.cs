using Xunit;

public abstract class BaseSortTest {
    protected abstract void sort(int[] array);

    [Fact]
    public void PassingTest()
    {
        var result = new int[] {2, 1};
        sort(result);
        Assert.Equal(new int[] {1, 2}, result);
    }
}