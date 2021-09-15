using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] majorityArray = new int[] { 1, 123, 123, 123123, 1231231 };

            int[] sortArray1 = new int[] { 1, 123, 123, 123123, 1231231 };

            int[] sortArray2 = new int[] { 14, 1234, 1231234, 12312314 };

            IMerger merger = new RecusiveMerger();
            
            int[] mergedArray = merger.MergeSortedArrays(sortArray1,sortArray1);

            IMajorityChecker majorityChecker = new MyMajorityChecker();

            foreach (var i in mergedArray)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine(majorityChecker.HasMajority(majorityArray));
        }
    }
}