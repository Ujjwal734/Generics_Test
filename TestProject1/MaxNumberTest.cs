using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void ReturnMaxNum()
        {
            TestMaximum maximum = new TestMaximum();
            int max = maximum.MaximumNumber(1, 2, 3);
            Assert.AreEqual(3, max);
        }
    }
}