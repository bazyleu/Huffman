using Huffman.Bytes;
using Huffman.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Huffman.Tests
{
    [TestClass]
    public class BitTableTests
    {
        [TestMethod]
        public void Test1()
        {
            const string testString = "there are rrrr he he!";
            var bytes = BitArrayUtilites.GetBytes(testString);
            var tree = TreeBuilder.BuildTree(new TreeBuilderQueue(BytesCalculator.Calculate(bytes)));
            var table = BitTable.BuildTable(tree);

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
