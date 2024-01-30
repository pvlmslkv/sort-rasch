using sort_rasch;
using sortirovkarascheskoi;
namespace UnitTest3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "-9 -5 -7 -1 -3";
            string output = "-9 -7 -5 -3 -1";
            SortRasch sorter = new SortRasch();
            string result = sorter.Sort(input);
            Assert.AreEqual(output, result);
        }
    }
}