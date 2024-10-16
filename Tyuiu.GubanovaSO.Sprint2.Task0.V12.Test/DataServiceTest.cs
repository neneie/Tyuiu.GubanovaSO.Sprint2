using Tyuiu.GubanovaSO.Sprint2.Task0.V12.Lib;
namespace Tyuiu.GubanovaSO.Sprint2.Task0.V12.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1095;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}