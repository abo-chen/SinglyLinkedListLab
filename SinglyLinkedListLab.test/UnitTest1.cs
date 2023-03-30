using System.Collections.Generic;
using System.Reflection.Metadata;

namespace SinglyLinkedListLab
{
    [TestClass]
    public class UnitTest1
    {
        private LinkedList _linkedList;

        [TestInitialize]
        public void Setup()
        {
            _linkedList = new LinkedList();
        }

        [TestMethod]
        public void TestSLLAddFirst()
        {
            string name1 = "Joe Blow";
            string name2 = "Joe Schmoe";

            _linkedList.AddFirst(name1);

            Assert.AreNotEqual(0, _linkedList.Count);
            Assert.AreEqual(name1, _linkedList.Head.Value);

            _linkedList.AddFirst(name2);
            Assert.AreEqual(name2, _linkedList.Head.Value);
        }

        [TestMethod]
        public void TestSLLAddLast()
        {
            string name1 = "Joe Blow";
            string name2 = "Joe Schmoe";

            _linkedList.AddLast(name1);

            Assert.AreNotEqual(0, _linkedList.Count);
            Assert.AreEqual(name1, _linkedList.Head.Value);

            _linkedList.AddLast(name2);
            Assert.AreEqual(name1, _linkedList.Head.Value);
        }

        [TestMethod]
        public void TestSLLRemoveFirst()
        {
            string name1 = "Joe Blow";
            string name2 = "Joe Schmoe";
            string name3 = "John Smith";
            string name4 = "Jane Doe";

            _linkedList.AddLast(name1);
            _linkedList.AddLast(name2);
            _linkedList.AddLast(name3);
            _linkedList.AddLast(name4);

            _linkedList.RemoveFirst();
            Assert.AreEqual(3, _linkedList.Count);
            Assert.AreEqual(name2, _linkedList.Head.Value);

            _linkedList.RemoveFirst();
            Assert.AreEqual(2, _linkedList.Count);
            Assert.AreEqual(name3, _linkedList.Head.Value);

            _linkedList.RemoveFirst();
            Assert.AreEqual(1, _linkedList.Count);
            Assert.AreEqual(name4, _linkedList.Head.Value);

            _linkedList.RemoveFirst();
            Assert.AreEqual(0, _linkedList.Count);
            Assert.AreEqual(null, _linkedList.Head);
        }

        [TestMethod]
        public void TestSLLGetValue()
        {
            string name0 = "Joe Blow";
            string name1 = "Joe Schmoe";
            string name2 = "John Smith";
            string name3 = "Jane Doe";
            string name4 = "Bob Bobberson";
            string name5 = "Sam Sammerson";
            string name6 = "Dave Daverson";

            _linkedList.AddLast(name0);
            _linkedList.AddLast(name1);
            _linkedList.AddLast(name2);
            _linkedList.AddLast(name3);
            _linkedList.AddLast(name4);
            _linkedList.AddLast(name5);
            _linkedList.AddLast(name6);

            Assert.AreEqual(name0, _linkedList.GetValue(0));
            Assert.AreEqual(name1, _linkedList.GetValue(1));
            Assert.AreEqual(name2, _linkedList.GetValue(2));
            Assert.AreEqual(name3, _linkedList.GetValue(3));
            Assert.AreEqual(name4, _linkedList.GetValue(4));
            Assert.AreEqual(name5, _linkedList.GetValue(5));
            Assert.AreEqual(name6, _linkedList.GetValue(6));
        }

        [TestMethod]
        public void TestSLLRemoveLast()
        {
            string name0 = "Joe Blow";
            string name1 = "Joe Schmoe";
            string name2 = "John Smith";
            string name3 = "Jane Doe";
            string name4 = "Bob Bobberson";
            string name5 = "Sam Sammerson";
            string name6 = "Dave Daverson";

            _linkedList.AddLast(name0);
            _linkedList.AddLast(name1);
            _linkedList.AddLast(name2);
            _linkedList.AddLast(name3);
            _linkedList.AddLast(name4);
            _linkedList.AddLast(name5);
            _linkedList.AddLast(name6);

            _linkedList.RemoveLast();
            Assert.AreEqual(5, _linkedList.Count - 1);
            Assert.AreEqual(name5, _linkedList.GetValue(5));

            _linkedList.RemoveLast();
            Assert.AreEqual(4, _linkedList.Count - 1);
            Assert.AreEqual(name4, _linkedList.GetValue(4));

            _linkedList.RemoveLast();
            Assert.AreEqual(3, _linkedList.Count - 1);
            Assert.AreEqual(name3, _linkedList.GetValue(3));

            _linkedList.RemoveLast();
            Assert.AreEqual(2, _linkedList.Count - 1);
            Assert.AreEqual(name2, _linkedList.GetValue(2));

            _linkedList.RemoveLast();
            Assert.AreEqual(1, _linkedList.Count - 1);
            Assert.AreEqual(name1, _linkedList.GetValue(1));

            _linkedList.RemoveLast();
            Assert.AreEqual(0, _linkedList.Count - 1);
            Assert.AreEqual(name0, _linkedList.GetValue(0));

            _linkedList.RemoveLast();
            Assert.AreEqual(0, _linkedList.Count);
            Assert.AreEqual(null, _linkedList.Head);
        }
    }
}