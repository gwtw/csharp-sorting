using Xunit;

public abstract class BaseIntegerSortingAlgorithmTest {
    protected IIntegerSortingAlgorithm _integerSortingAlgorithm;

    public BaseIntegerSortingAlgorithmTest(IIntegerSortingAlgorithm algorithm) {
        _integerSortingAlgorithm = algorithm;
    }

    private void Sort(int[] array) {
        _integerSortingAlgorithm.Sort(array);
    }

    [Fact]
    public void SortEmptyArrayTest() {
        var result = new int[] {};
        Sort(result);
        Assert.Equal(new int[] {}, result);
    }

    [Fact]
    public void SortSmallSortedArrayTest() {
        var result = new int[] {1,2,3,4,5};
        Sort(result);
        Assert.Equal(new int[] {1,2,3,4,5}, result);
    }

    [Fact]
    public void SortSmallReverseSortedArrayTest() {
        var result = new int[] {5,4,3,2,1};
        Sort(result);
        Assert.Equal(new int[] {1,2,3,4,5}, result);
    }

    [Fact]
    public void SortSmallSortedArrayWithOnlyNegativeValuesTest() {
        var result = new int[] {-5,-4,-3,-2,-1};
        Sort(result);
        Assert.Equal(new int[] {-5,-4,-3,-2,-1}, result);
    }

    [Fact]
    public void SortSmallReverseSortedArrayWithOnlyNegativeValuesTest() {
        var result = new int[] {-1,-2,-3,-4,-5};
        Sort(result);
        Assert.Equal(new int[] {-5,-4,-3,-2,-1}, result);
    }

    [Fact]
    public void SortSmallSortedArrayWithTwoValuesSwappedTest() {
        var result = new int[] {1,2,5,4,3};
        Sort(result);
        Assert.Equal(new int[] {1,2,3,4,5}, result);
    }

    [Fact]
    public void SortLargeSortedArrayTest() {
        var result = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
        Sort(result);
        Assert.Equal(new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20}, result);
    }

    [Fact]
    public void SortLargeReverseSortedArrayTest() {
        var result = new int[] {20,19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1,0};
        Sort(result);
        Assert.Equal(new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20}, result);
    }

    [Fact]
    public void SortLargeArrayWithTwoValuesSwappedTest() {
        var result = new int[] {0,1,2,8,4,5,6,7,3,9,10,11,12,13,14,15,16,17,18,19,20};
        Sort(result);
        Assert.Equal(new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20}, result);
    }

    [Fact]
    public void SortLargeSortedArrayWithOnlyNegativeValuesTest() {
        var result = new int[] {-20,-19,-18,-17,-16,-15,-14,-13,-12,-11,-10,-9,-8,-7,-6,-5,-4,-3,-2,-1};
        Sort(result);
        Assert.Equal(new int[] {-20,-19,-18,-17,-16,-15,-14,-13,-12,-11,-10,-9,-8,-7,-6,-5,-4,-3,-2,-1}, result);
    }

    [Fact]
    public void SortLargeReverseSortedArrayWithOnlyNegativeValuesTest() {
        var result = new int[] {-1,-2,-3,-4,-5,-6,-7,-8,-9,-10,-11,-12,-13,-14,-15,-16,-17,-18,-19,-20};
        Sort(result);
        Assert.Equal(new int[] {-20,-19,-18,-17,-16,-15,-14,-13,-12,-11,-10,-9,-8,-7,-6,-5,-4,-3,-2,-1}, result);
    }

    [Fact]
    public void SortJumbledArrayWithSmallRangeOfValuesTest() {
        var result = new int[] {5,-3,2,0,-5,1,4,-4,-2,3,-1};
        Sort(result);
        Assert.Equal(new int[] {-5,-4,-3,-2,-1,0,1,2,3,4,5}, result);
    }

    [Fact]
    public void SortJumbledArrayWithLargeRangeOfValuesTest() {
        var result = new int[] {102,10,-50,2938,108,-4011,-38,523,16};
        Sort(result);
        Assert.Equal(new int[] {-4011,-50,-38,10,16,102,108,523,2938}, result);
    }

    [Fact]
    public void SortArrayWithDuplicateValuesTest() {
        var result = new int[] {-2,-7,1,9,-7,1,-2,10,-7,-7};
        Sort(result);
        Assert.Equal(new int[] {-7,-7,-7,-7,-2,-2,1,1,9,10}, result);
    }
}