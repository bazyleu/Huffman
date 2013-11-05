using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Huffman;
using Huffman.Tree;

namespace Huffman.Tests
{
    [TestClass]
    public class BitTableTests
    {
        [TestMethod]
        public void Test1()
        {
            string testString = "there are rrrr he he!";
            BitTable bitTable = new BitTable();
            TreeBuilder treeBuilder = new TreeBuilder();
            var bytes = GetBytes(testString);
            var tree = treeBuilder.BuildTree(new TreeBuilderQueue(BytesCalculator.Calculate(bytes)));
            var table = bitTable.BuildTable(tree);

            Dictionary<Byte, string> dicDebug = new Dictionary<Byte, string>();
            foreach (var item in table)
            {
                dicDebug.Add(item.Key, GetString(item.Value)); 
            }
            var ar1 = dicDebug[bytes[14]];
            var ar2 = dicDebug[bytes[1]];
            var ar3 = dicDebug[bytes[2]];
            var ar4 = dicDebug[bytes[3]];
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(BitArray bitArray)
        {
            StringBuilder sb = new StringBuilder(bitArray.Length);

            for (var i = 0; i < bitArray.Length; i++)
            {
                if (bitArray[i])
                {
                    sb.Append('1');
                }
                else
                {
                    sb.Append('0');
                }
            }

            return sb.ToString();
        }
    }
}
