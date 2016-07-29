using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;


namespace Huffman.Tests
{
    [TestClass]
    public class HuffmanEncoderTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string testString = @"Aenean neque lorem, ultricies mollis nulla a,
                                        sodales finibus libero. Morbi interdum augue quis turpis 
                                        sagittis, nec elementum lectus pharetra. Pellentesque sagittis mi 
                                        id justo tristique, quis sollicitudin orci luctus.";
            var bytes = BitArrayUtilites.GetBytes(testString);
            string startStr = Encoding.Unicode.GetString(bytes);
            var encode = HuffmanEncoder.Encode(bytes);
            var decode = HuffmanEncoder.Decode(encode);
            string decodeStr = Encoding.Unicode.GetString(decode);

            Assert.IsTrue(startStr == decodeStr);
        }
    }
}
