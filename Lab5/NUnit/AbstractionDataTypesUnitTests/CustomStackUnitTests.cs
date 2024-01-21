using AbstractionDataTypes;
using NUnit.Framework;

namespace AbstractionDataTypesUnitTests
{
    public class Tests
    {
        private CustomStack sut;

        [SetUp]
        public void Setup()
        {
            sut = new CustomStack();
        }

        [Test]
        public void ShouldBeEmptyWhenCreated()
        {
            Assert.IsTrue(sut.IsEmpty());
        }

        [Test]
        public void ShouldNotBeEmptyWhenElementPushed()
        {
            sut.Push(0);
            Assert.IsFalse(sut.IsEmpty());
        }

        [Test]
        public void ShouldThrowAnExceptionIfStackEmptyAndPopped()
        {
            Assert.Throws<System.InvalidOperationException>(() => sut.Pop());
        }

        [Test]
        public void ShouldBeEmptyIfPushedAndPopped()
        {
            sut.Push(0);
            sut.Pop();
            Assert.IsTrue(sut.IsEmpty());
        }

        [Test]
        public void ShouldNotBeEmptyWhenTwoPushedOnePopped()
        {
            sut.Push(1);
            sut.Push(2);
            sut.Pop();
            Assert.IsFalse(sut.IsEmpty());
        }

        [TestCase(-10)]
        [TestCase(0)]
        [TestCase(10)]
        public void ShouldReturnPoppedElementWhenPoppedPushed(int element)
        {
            sut.Push(element);
            Assert.AreEqual(element, sut.Pop());
        }

        [Test]
        public void ShouldReturnPoppedElementWhenTwoPoppedTwoPushed()
        {
            sut.Push(5);
            sut.Push(10);
            Assert.AreEqual(10, sut.Pop());
            Assert.AreEqual(5, sut.Pop());
        }
    }
}
