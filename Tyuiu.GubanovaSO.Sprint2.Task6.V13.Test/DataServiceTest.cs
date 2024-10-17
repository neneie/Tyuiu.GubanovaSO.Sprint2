using Tyuiu.GubanovaSO.Sprint2.Task6.V13.Lib;
namespace Tyuiu.GubanovaSO.Sprint2.Task6.V13.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("1.2.2000", ds.FindDateOfNextDay(31, 1, 2000));
            Assert.AreEqual("1.1.2001", ds.FindDateOfNextDay(31, 12, 2000));
            Assert.AreEqual("1.3.2000", ds.FindDateOfNextDay(29, 2, 2000));
            Assert.AreEqual("1.5.2000", ds.FindDateOfNextDay(30, 4, 2000));

            Assert.Throws<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(-1, -1, -1);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2025, 13, 32);
            });
        }
    }
}