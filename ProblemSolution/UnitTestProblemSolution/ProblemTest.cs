using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolution;

namespace UnitTestProblemSolution
{
    [TestClass]
    public class UnitTestProblem
    {
        [TestMethod]
        public void PushMinTest()
        {
            var intStack = new IntegerStack();

            var expectedInt = 1;

            intStack.Push(expectedInt);

            var minInt = intStack.Min();

            Assert.AreEqual(expectedInt, minInt);
        }

        [TestMethod]
        public void PushPopTest()
        {
            var intStack = new IntegerStack();
            
            var expectedInt = 12345;

            intStack.Push(expectedInt);
            var popInt = intStack.Pop();

            Assert.AreEqual(expectedInt, popInt);
        }

        [TestMethod]
        public void PushPopTwiceTest()
        {
            var intStack = new IntegerStack();

            intStack.Push(2);
            intStack.Push(2);
            intStack.Push(1);
            intStack.Push(1);

            intStack.Pop();
            intStack.Pop();

            var mininumInt = intStack.Min();

            Assert.AreEqual(2, mininumInt);
        }

        [TestMethod]
        public void PushShuffleTwicePopTest()
        {
            var intStack = new IntegerStack();

            intStack.Push(3);
            intStack.Push(7);
            intStack.Push(5);
            intStack.Push(1);
            intStack.Push(6);
            intStack.Push(1);

            intStack.Pop();

            var mininumInt = intStack.Min();

            Assert.AreEqual(1, mininumInt);
        }

        [TestMethod]
        public void MinimumTest()
        {
            var intStack = new IntegerStack();

            intStack.Push(1123);
            intStack.Push(5123);
            intStack.Push(8);
            intStack.Push(5322);
            intStack.Push(1231);
            var mininumInt = intStack.Min();

            Assert.AreEqual(8, mininumInt);
        }
        
        [TestMethod]
        public void MinimumUpwardTest()
        {
            var intStack = new IntegerStack();

            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            intStack.Push(4);
            intStack.Push(5);
            var mininumInt = intStack.Min();

            Assert.AreEqual(1, mininumInt);
        }

        [TestMethod]
        public void MinimumDownwardTest()
        {
            var intStack = new IntegerStack();

            intStack.Push(5);
            intStack.Push(4);
            intStack.Push(3);
            intStack.Push(2);
            intStack.Push(1);
            var mininumInt = intStack.Min();

            Assert.AreEqual(1, mininumInt);
        }

        [TestMethod]
        public void MinimumShuffleTest()
        {
            var intStack = new IntegerStack();

            intStack.Push(3);
            intStack.Push(5);
            intStack.Push(6);
            intStack.Push(1);
            intStack.Push(2);
            var mininumInt = intStack.Min();

            Assert.AreEqual(1, mininumInt);
        }

        [TestMethod]
        public void PopMinimumTest()
        {
            var intStack = new IntegerStack();

            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            intStack.Push(4);
            intStack.Push(5);

            var poppedInt = intStack.Pop();
            var mininumInt = intStack.Min();

            Assert.AreEqual(1, mininumInt);
        }

        [TestMethod]
        public void PopTwiceTest()
        {
            var intStack = new IntegerStack();

            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);            

            intStack.Pop();
            intStack.Pop();


            var mininumInt = intStack.Min();

            Assert.AreEqual(1, mininumInt);
        }
    }
}
