using Microsoft.VisualStudio.TestTools.UnitTesting;
using Browser_Simulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Browser_Simulator.Tests
{
    [TestClass()]
    public class StringStackTests
    {
        [TestMethod()]
        public void PushTest()
        {
            StringStack stack = new StringStack(3);

            stack.Push("A");
            stack.Push("B");

            Assert.AreEqual(2, stack.Count);
            Assert.AreEqual("B", stack.Peek());
        }

        [TestMethod()]
        public void Pop_PeekTest()
        {
            StringStack stack = new StringStack(3);

            string popped = stack.Pop();
            Assert.AreEqual("B", popped);
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual("A", stack.Peek());

            string popped2 = stack.Pop();
            Assert.AreEqual("A", popped2);
            Assert.AreEqual(0, stack.Count);
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod()]
        public void SwapTest()
        {
            StringStack stack = new StringStack(3);

            stack.Push("A");
            stack.Push("B");
            stack.Push("C");

            stack.Swap();

            Assert.AreEqual("C, B, A", stack.ToString());
        }

        [TestMethod()]
        public void Clear()
        {
            StringStack stack = new StringStack(3);

            stack.Push("A");
            stack.Push("B");
            stack.Push("C");

            stack.Clear();

            Assert.AreEqual(0, stack.Count);
            Assert.IsTrue(stack.IsEmpty);
        }
    }
}