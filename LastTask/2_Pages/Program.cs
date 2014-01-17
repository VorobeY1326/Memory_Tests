namespace _2_Pages
{
    public static class Program
    {
        public static void Main()
        {
            var veryBigArray = new byte[500*1000*1000];
            var pagesTest = new PagesTest(veryBigArray);

            pagesTest.Run();
        }
    }
}
