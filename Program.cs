using System;

using GrowingWithTheWeb.Sorting;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = new int[] {1, 4, 3, 2};
            var sortingAlgorithm = new BubbleSort();
            sortingAlgorithm.sort(a);
            foreach (var b in a) {
                Console.WriteLine(b);
            }
        }
    }
}
