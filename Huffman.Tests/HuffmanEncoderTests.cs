using System.Collections;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


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
            string startStr = Encoding.Unicode.GetString(bytes);
            var encode = HuffmanEncoder.Encode(bytes);
            var decode = HuffmanEncoder.Decode(encode);
            string decodeStr = Encoding.Unicode.GetString(decode);

            Assert.IsTrue(startStr == decodeStr);
        }
    }
}
