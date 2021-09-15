using System.Collections.Generic;


namespace test
{
    public class MyMajorityChecker : IMajorityChecker
    {
        public bool HasMajority(int[] majorityArray)
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