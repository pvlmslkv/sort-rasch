using sort_rasch;
using sortirovkarascheskoi;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "5 4 3 2 1";
            string output = "1 2 3 4 5";
            SortRasch sorter = new SortRasch();
            string result = sorter.Sort(input);
            Assert.AreEqual(output, result);
        }
    }
}