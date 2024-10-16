using Tyuiu.GubanovaSO.Sprint2.Task1.V15.Lib;
namespace Tyuiu.GubanovaSO.Sprint2.Task1.V15.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 415;
            int b = 616;
            int c = 134;
            int d = 127;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations( a,  b,  c,  d);
            bool[] wait = new bool[6] { true, false, false, false, false, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}