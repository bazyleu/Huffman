using System.Collections.Generic;
using System.Collections;

using Huffman.Tree;

namespace Huffman
{
    public class BitTable
    {
        public Dictionary<byte, BitArray> BuildTable(ITreeNode node)
        {
            Dictionary<byte, BitArray> dictionary = new Dictionary<byte, BitArray>();

            byte b = byte.MinValue;
            do
            {
                dictionary.Add(b, new BitArray(GenerateBits(node, b).ToArray()));
            } while (b++ < byte.MaxValue);

            return dictionary;
        }

        private List<bool> GenerateBits(ITreeNode tree, byte value)
        {
            List<bool> bits = new List<bool>();

            return Find(tree, value, bits);
        }

        private List<bool> Find(ITreeNode tree, byte value, List<bool> bits)
        {

            if (value == tree.Value)
            {
                return bits;
            }

            if (tree.Left != null)
            {
                bits.Add(true);
                var result = Find(tree.Left, value, bits);
                if (result != null)
                {
                    return result;
                }
                bits.Remove(bits[bits.Count-1]);
            }

            if (tree.Rigth != null)
            {
                bits.Add(false);
                var result = Find(tree.Rigth, value, bits);
                if (result != null)
                {
                    return result;
                }
                bits.Remove(bits[bits.Count - 1]);
            }

            return null;
        }
 
    }
}
