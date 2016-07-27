namespace GrowingWithTheWeb.Sorting
{
    public class BubbleSortOptimised : ISortingAlgorithm {
        public void sort(int[] array) {
            int unsortedBelow = array.Length;
            while (unsortedBelow != 0) {
                int lastSwap = 0;
                for (int i = 1; i < unsortedBelow; i++) {
                    if (array[i - 1] > array[i]) {
                        swap(array, i, i - 1);
                        lastSwap = i;
                    }
                }
                unsortedBelow = lastSwap;
            }
        }

        private void swap(int[] array, int a, int b) {
            var temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}