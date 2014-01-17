namespace _3_TheCakeIsALie
{
    public class WideCountersTest : CountersTest
    {
        private readonly int count;
        private volatile int[][] counters;

        public WideCountersTest(int threadsCount, int count) : base(threadsCount)
        {
            this.count = count;
            counters = new int[threadsCount][];
            for (int i = 0; i < threadsCount; i++)
                counters[i] = new int[128];
        }

        protected override string TestName
        {
            get { return "Wide counters"; }
        }

        protected override void AddCounter(int counterId)
        {
            for (int i = 0; i < count; i++)
                counters[counterId][0]++;
        } 
    }
}