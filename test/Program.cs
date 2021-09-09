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

            Sorter sorter = new Sorter();
            
            int[] mergedArray = sorter.MergeSortedArray(sortArray1,sortArray1);

            foreach (var i in mergedArray)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine(HasMajority(majorityArray));
        }

        static bool HasMajority(int[] majorityArray)
        {

            List<ValueCountPair> vcList = new List<ValueCountPair>();
            for (int i = majorityArray.GetLength(0) - 1; i >= 0; i--)
            {
                int currentValue = majorityArray[i];
                ValueCountPair vcp = vcList.Find(vc => vc.value == currentValue);
                if (vcp == null)
                    vcList.Add(new ValueCountPair(currentValue));
                else
                {
                    vcp.Add(1);
                    if(vcp.count>majorityArray.Length/2)
                        return true;
                }
            }
            int max = 0;
            foreach (var vcp in vcList)
            {
                if (vcp.count > max)
                    max = vcp.count;
            }
            return max > majorityArray.Length / 2;
        }
    }
}