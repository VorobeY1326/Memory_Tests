namespace _3_TheCakeIsALie
{
    public class UsualCountersTest : CountersTest
    {
        private readonly int count;
        private volatile int[] counters;

        public UsualCountersTest(int threadsCount, int count) : base(threadsCount)
        {
            this.count = count;
            counters = new int[threadsCount];
        }

        protected override string TestName
        {
            get { return "Usual counters"; }
        }

        protected override void AddCounter(int counterId)
        {
            for (int i = 0; i < count; i++)
                counters[counterId]++;
        }
    }
}