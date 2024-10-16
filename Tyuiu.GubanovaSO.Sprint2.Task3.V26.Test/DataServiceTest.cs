using Tyuiu.GubanovaSO.Sprint2.Task3.V26.Lib;
namespace Tyuiu.GubanovaSO.Sprint2.Task3.V26.Test
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
            var ds = new DataService();
            double x = 1;
            double wait = 4.702;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }


        [Test]
        public void TestMethod2()
        {
            var ds = new DataService();
            double x = 0;
            double wait = 1.667;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }


        [Test]
        public void TestMethod3()
        {
            var ds = new DataService();
            double x = -1;
            double wait = -4.754;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }


        [Test]
        public void TestMethod4()
        {
            var ds = new DataService();
            double x = -31;
            double wait = -247.968;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
