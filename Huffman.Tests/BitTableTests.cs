using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Huffman.Tree;

namespace Huffman.Tests
{
    [TestClass]
    public class BitTableTests
    {
        [TestMethod]
        public void Test1()
        {
            const string testString = "there are rrrr he he!";
            BitTable bitTable = new BitTable();
            TreeBuilder treeBuilder = new TreeBuilder();
            var bytes = BitArrayUtilites.GetBytes(testString);
            var tree = treeBuilder.BuildTree(new TreeBuilderQueue(BytesCalculator.Calculate(bytes)));
            var table = bitTable.BuildTable(tree);

            Dictionary<Byte, string> dicDebug = new Dictionary<Byte, string>();
            foreach (var item in table)
            {
                dicDebug.Add(item.Key, BitArrayUtilites.GetString(item.Value)); 
            }
            var ar1 = dicDebug[bytes[14]];
            var ar2 = dicDebug[bytes[1]];
            var ar3 = dicDebug[bytes[2]];
            var ar4 = dicDebug[bytes[3]];
        }
    }
}
