using System;
using NUnit.Framework;

namespace CSLib.Test
{
    [TestFixture]
    public class NUnit_CSharpDemoTests
    {
        private CSharpDemo _demo;

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Optional method - SetUp method runs before each test");
            _demo = new CSharpDemo();
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Optional method - TearDown runs after each test");
        }

        [Test]
        public void NUnit_Test1()
        {
            Console.WriteLine("Test1, set state to 5");
            _demo.State = 5;

            Console.WriteLine("Test1, call Double()");
            _demo.Double();

            Console.WriteLine("Test1, assert state is 10");
            Assert.AreEqual(10, _demo.State);
        }

        [Test]
        public void NUnit_Test2()
        {
            Console.WriteLine("Test2, set state to 20");
            _demo.State = 20;

            Console.WriteLine("Test2, call Double()");
            _demo.Double();

            Console.WriteLine("Test2, assert state is 40");
            Assert.AreEqual(40, _demo.State);
        }

        [TestCase(20, 40)]
        [TestCase(30, 60)]
        [TestCase(50, 100)]
        [TestCase(-1, -2)]
        [TestCase(0, 0)]
        public void NUnit_TestCaseDemo(int initialState, int expected)
        {

            Console.WriteLine("TestCaseDemo, set state to {0}", initialState);
            _demo.State = initialState;

            Console.WriteLine("TestCaseDemo, call Double()");
            _demo.Double();

            Console.WriteLine("TestCaseDemo, assert state is {0}", expected);
            Assert.AreEqual(expected, _demo.State);
        }
    }
}