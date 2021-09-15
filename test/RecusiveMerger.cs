namespace test
{
    public class RecusiveMerger : IMerger
    {

        public int[] MergeSortedArrays(int[] a, int[] b)
        {
            return Merge(new int[a.Length + b.Length], a, 0, b, 0);
        }

        public int[] Merge(int[] c, int[] a, int AIndex, int[] b, int BIndex)
        {
            if (AIndex < a.Length && a[AIndex] <= b[BIndex])
            {
                c[AIndex + BIndex] = a[AIndex];
                AIndex++;
            }
            else if (BIndex < b.Length)
            {
                c[AIndex + BIndex] = b[BIndex];
                BIndex++;
            }
            else
                return c;
            return Merge(c,a,AIndex,b,BIndex);
        }
    }
}