namespace GrowingWithTheWeb.Sorting
{
    public class BubbleSort : ISortingAlgorithm
    {
        public void sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        swap(array, j, j - 1);
                    }
                }
            }
        }

        private void swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}