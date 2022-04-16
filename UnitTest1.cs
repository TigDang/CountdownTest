using NUnit.Framework;
using PracticeTwo;

namespace CountdownTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var cntdwn = new CountDown();
            Assert.Pass();
        }
    }
}