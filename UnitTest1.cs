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
            var sbsc = new Subscriber(new CountDown[] { cntdwn });

            cntdwn.Timer(100, "Some text");

            cntdwn.RaiseCountDownEvent();

            Assert.Pass();
        }
    }
}