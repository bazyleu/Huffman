using System;
using System.Collections.Generic;

namespace Huffman.Bytes
{
    public static class DictionarySerializer
    {
        public static byte[] Serialize(Dictionary<byte, long> dictionary)
        {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(BitConverter.GetBytes(dictionary.Count));
            foreach (var item in dictionary)
            {
                bytes.AddRange(BitConverter.GetBytes(item.Key));
                bytes.AddRange(BitConverter.GetBytes(item.Value));
            }
            return bytes.ToArray();
        }

        public static DictionarySerializerResult Deserialize(byte[] bytes)
        {
            Dictionary<byte, long> dictionary = new Dictionary<byte, long>();
            int pointer = 0;
            long count = BitConverter.ToInt64(bytes, pointer);
            pointer += 8;
            for (int i = 0; i < count; i++)
            {
                dictionary.Add(bytes[pointer], BitConverter.ToInt64(bytes, pointer + 1));
                pointer += 8;
            }
            return new DictionarySerializerResult()
                   {
                       Dictionary = dictionary,
                       SizeOfBytes = pointer
                   };
        }

 
    }
}
