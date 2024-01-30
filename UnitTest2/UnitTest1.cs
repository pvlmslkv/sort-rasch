using sort_rasch;
using sortirovkarascheskoi;
namespace UnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "1 2 3 4 5";
            string output = "1 2 3 4 5";
            SortRasch sorter = new SortRasch();
            string result = sorter.Sort(input);
            Assert.AreEqual(output, result);
        }
    }
}
