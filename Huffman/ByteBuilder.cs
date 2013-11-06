using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    class ByteBuilder
    {
        private readonly List<byte> Bytes;
        private long bitFilled;

        public ByteBuilder()
        {
            Bytes = new List<byte>();
            bitFilled = 0;
        }

 
        public void Append(BitArray bitArray)
        {
            if (bitFilled % 8 == 0)
            {
                
                //Bytes.Add(0)
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bitArray"></param>
        /// <param name="b"></param>
        /// <param name="position"></param>
        /// <returns> rest bits</returns>
        private BitArray AppendBitToByte(BitArray bitArray, byte b, int position)
        {

            return bitArray;
        }


        public static void SetBit(ref byte byteValue, int position, bool bitValue)
        {
            if (bitValue)
            {
                byteValue = (byte)(byteValue | (1 << position));
            }
            else
            {
                byteValue = (byte)(byteValue & ~(1 << position));
            }
        }
    }
}
