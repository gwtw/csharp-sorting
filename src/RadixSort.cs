namespace GrowingWithTheWeb.Sorting
{
    public class RadixSort : IIntegerSortingAlgorithm {
        public void Sort(int[] array) {
            Sort(array, 10);
        }

        public void Sort(int[] array, int radix) {
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

            // Perform counting sort on each exponent/digit, starting at the least
            // significant digit
            int exponent = 1;
            while ((maxValue - minValue) / exponent >= 1) {
                CountingSortByDigit(array, radix, exponent, minValue);
                exponent *= radix;
            }
        }

        public void CountingSortByDigit(
                int[] array, int radix, int exponent, int minValue) {
            int bucketIndex;
            int[] buckets = new int[radix];
            int[] output = new int[array.Length];

            // Initialize bucket
            for (int i = 0; i < radix; i++) {
                buckets[i] = 0;
            }

            // Count frequencies
            for (int i = 0; i < array.Length; i++) {
                bucketIndex = (int)(((array[i] - minValue) / exponent) % radix);
                buckets[bucketIndex]++;
            }

            // Compute cumulates
            for (int i = 1; i < radix; i++) {
                buckets[i] += buckets[i - 1];
            }

            // Move records
            for (int i = array.Length - 1; i >= 0; i--) {
                bucketIndex = (int)(((array[i] - minValue) / exponent) % radix);
                output[--buckets[bucketIndex]] = array[i];
            }

            // Copy back
            for (int i = 0; i < array.Length; i++) {
                array[i] = output[i];
            }
        }
    }
}