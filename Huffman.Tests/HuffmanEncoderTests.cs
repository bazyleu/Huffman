using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Huffman;

namespace Huffman.Tests
{
    [TestClass]
    public class HuffmanEncoderTests
    {
        [TestMethod]
        public void Test1()
        {
            const string testString = "there are rrrr he he!";
            var bytes = BitArrayUtilites.GetBytes(testString);
            HuffmanEncoder encoder = new HuffmanEncoder();
            var result = encoder.Encode(bytes);
            BitArray bitArray = new BitArray(result);
            string resultStr = BitArrayUtilites.GetString(bitArray);
        }
    }
}
