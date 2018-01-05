using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using data_estructures.BinaryTree;
namespace Test
{
    [TestClass]
    public class BSTTest
    {
        [TestMethod]
        public void TesBST1()
        {
            BST<int> BT1 = new BST<int>();
            BT1.Add(1);
           
            Assert.AreEqual(BT1.Contains(1), true);
            Assert.AreEqual(BT1.Contains(2), false);
            BT1.Remove(1);
            Assert.AreEqual(BT1.Contains(1), false);
          
        }
    }
}
