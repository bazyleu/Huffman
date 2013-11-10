using System.Collections;
using System.Text;

namespace Huffman.Tests
{
    public class BitArrayUtilites
    {
        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static string GetString(BitArray bitArray)
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