using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Huffman.Tree;

namespace Huffman
{
    public class HuffmanEncoder
    {
        public byte[] Encode(byte[] bytes)
        {
            return Encode(bytes, 
                new BitTable().BuildTable(
                            new TreeBuilder().BuildTree(
                                   new TreeBuilderQueue(BytesCalculator.Calculate(bytes)))));
        }


        private byte[] Encode(byte[] bytes, Dictionary<byte, BitArray> bitTable)
        {
            ByteBuilder byteBuilder = new ByteBuilder();
            return null;
        }
    }
}
