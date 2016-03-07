using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackAndUnitTesting;

namespace StackTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Poping_From_Stack()
        {
            String testString = "TestString";
            Stack testStack = new Stack();
            testStack.Push(testString);

            Assert.AreEqual(testString, testStack.Pop());  
        }

        [TestMethod]
        public void Count_The_Stack()
        {
            Stack testStack = new Stack();
            String testString1 = "TestString1";
            String testString2 = "TestString2";
            String testString3 = "TestString3";
            String testString4 = "TestString4";

            testStack.Push(testString1);
            testStack.Push(testString2);
            testStack.Push(testString3);
            testStack.Push(testString4);

            int expectedCount = 4;

            Assert.AreEqual(expectedCount, testStack.Count());
        }

        [TestMethod]
        public void IsEmpty_On_NewStack()
        {
            Stack testStack = new Stack();
            bool expected = true;

            Assert.AreEqual(expected, testStack.isEmpty());
        }

        [TestMethod]
        public void IsEmpty_On_PoppedStack()
        {
            Stack testStack = new Stack();
            String testString = "TestString";

            testStack.Push(testString);
            testStack.Push(testString);

            testStack.Pop();
            testStack.Pop();

            bool expected = true;

            Assert.AreEqual(expected, testStack.isEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Peek_On_EmptyStack()
        {
            Stack testStack = new Stack();

            testStack.Peek();
        }

        [TestMethod]
        public void PushSeveralItems_Then_Peek()
        {
            Stack testStack = new Stack();
            String testString1 = "TestString1";
            String testString2 = "TestString2";
            String testString3 = "TestString3";
            String testString4 = "TestString4";

            testStack.Push(testString1);
            testStack.Push(testString2);
            testStack.Push(testString3);
            testStack.Push(testString4);

            string expected = "TestString4";
            int expectedCount = 4;

            Assert.AreEqual(expected, testStack.Peek());
            Assert.AreEqual(expectedCount, testStack.Count());
        }
    }
}
