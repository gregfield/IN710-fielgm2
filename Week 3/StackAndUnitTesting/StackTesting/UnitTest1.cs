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
    }
}
