namespace test
{
    public class ValueCountPair
    {
        public int count{get; set;}
        public int value{get; set;}

        public ValueCountPair(int value){
            this.value=value;
            this.count=1;
        }
        public void Add(int amount){
            count+=amount;
        }
    }
}