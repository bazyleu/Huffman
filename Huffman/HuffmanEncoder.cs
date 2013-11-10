using Huffman.Bytes;
using Huffman.Tree;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
            List<byte> outputBytes = new List<byte>(bytes.Count());
            foreach (var inputByte in bytes)
            {
                byteBuilder.Append(bitTable[inputByte]);
                while (byteBuilder.IsByteRedy())
                {
                    outputBytes.Add(byteBuilder.GetByte());
                }
            }

            outputBytes.AddRange(byteBuilder.GetAllBytes());

            return outputBytes.ToArray();
        }
    }
}
