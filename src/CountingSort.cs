namespace GrowingWithTheWeb.Sorting
{
    public class CountingSort : IIntegerSortingAlgorithm {
        public void Sort(int[] array) {
            if (array.Length == 0) {
                return;
            }

            // Determine minimum and maximum values
            int minValue = array[0];
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++) {
                if (array[i] < minValue) {
                    minValue = array[i];
                } else if (array[i] > maxValue) {
                    maxValue = array[i];
                }
            }

            Sort(array, minValue, maxValue);
        }

        public void Sort(int[] array, int minValue, int maxValue) {
            int[] buckets = new int[maxValue - minValue + 1];

            for (int i = 0; i < array.Length; i++) {
                buckets[array[i] - minValue]++;
            }

            int sortedIndex = 0;
            for (int i = 0; i < buckets.Length; i++) {
                while (buckets[i] > 0) {
                    array[sortedIndex++] = i + minValue;
                    buckets[i]--;
                }
            }
        }
    }
}