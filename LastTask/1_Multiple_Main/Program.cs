namespace LastTask
{
    public static class Program
    {
        public static void Main()
        {
            const int count = 20;

            for (int i = 0; i < 5; i++)
            {
                var threadsTest = new ThreadsTest(count);
                threadsTest.Run();

                var processesTest = new ProcessesTest(count);
                processesTest.Run();
            }
        }
    }
}