namespace _3_TheCakeIsALie
{
    public static class Program
    {
        public static void Main()
        {
            const int threadsCount = 20; 
            const int count = 1000000;

            var usualCountersTest = new UsualCountersTest(threadsCount, count);
            var wideCountersTest = new WideCountersTest(threadsCount, count);

            usualCountersTest.Run();
            wideCountersTest.Run();
        }
    }
}
