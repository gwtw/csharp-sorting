using System;

using GrowingWithTheWeb.Sorting;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = new int[] {20,19,18,16,15,14,13,12,11,10,9,8,7,6,5,4,3,17,2,1,0};
            var sortingAlgorithm = new BucketSort();
            sortingAlgorithm.Sort(a);
            foreach (var b in a) {
                Console.WriteLine(b);
            }
        }
    }
}
