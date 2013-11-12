namespace Huffman.Extensions
{
    public static class ByteExtensions
    {
        public static bool GetBit(this byte b, int position)
        {
            return (b & (1 << position)) != 0;
        }
    }
}
