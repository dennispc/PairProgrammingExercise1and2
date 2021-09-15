namespace test
{
    public class Merger : IMerger
    {
        public Merger() 
        {
        }

        public int[] MergeSortedArrays(int[] a, int[] b)
        {
            int indexA = 0;
            int indexB = 0;
            int[] c = new int[a.Length + b.Length];

            int indexC = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (indexA < a.Length && indexB<b.Length && a[indexA] <= b[indexB])
                {
                    c[indexC++] = a[indexA++];
                }
                else if(indexB<b.Length)
                {
                    c[indexC++] = b[indexB++];
                }
            }
            return c;
        }
    }
}