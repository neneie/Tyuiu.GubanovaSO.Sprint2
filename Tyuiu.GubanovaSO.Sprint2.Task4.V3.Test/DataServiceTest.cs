using Tyuiu.GubanovaSO.Sprint2.Task4.V3.Lib;
namespace Tyuiu.GubanovaSO.Sprint2.Task4.V3.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()
        {
            double x = 1;
            double y = 3;
            DataService ds = new DataService();
            Assert.AreEqual(3.667, ds.Calculate(x, y));
        }
    }
}