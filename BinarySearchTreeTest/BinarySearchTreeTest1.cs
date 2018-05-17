using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchTree;

namespace BinarySearchTreeTest
{
    [TestClass]
    public class BinarySearchTreeTest1
    {
        [TestMethod]
        public void Add_AddsValuesToBinaryTree_ValuesExist()
        {
            Tree searchTree= new Tree();
            Node node = new Node();
            bool expected = true;
            bool actual = false;

            searchTree.AddNode(node, 53);
            searchTree.AddNode(node, 15);
            searchTree.AddNode(node, 67);
            searchTree.AddNode(node, 43);
            searchTree.AddNode(node, 12);
            searchTree.AddNode(node, 78);
            searchTree.AddNode(node, 56);
            searchTree.AddNode(node, 78);

            actual = searchTree.FindValue(node,43);

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]

        public void Find_DirectionsPrint_AreCorrect()
        {
            Tree searchTree = new Tree();
            Node node = new Node();
            string expectedDirections = "Right , Left , Left ";
            

            searchTree.AddNode(node, 53);
            searchTree.AddNode(node, 15);
            searchTree.AddNode(node, 67);
            searchTree.AddNode(node, 43);
            searchTree.AddNode(node, 12);
            searchTree.AddNode(node, 78);
            searchTree.AddNode(node, 56);
            searchTree.AddNode(node, 78);

            searchTree.FindValue(node, 12);
            string actualDirections = searchTree.directionsString;
            

            Assert.AreEqual(expectedDirections, actualDirections);


        }
    }
}
