using System.Collections.Generic;

namespace Huffman.Bytes
{
    public class DictionarySerializerResult
    {
        public Dictionary<byte, long> Dictionary { get; set; }
        public int SizeOfBytes { get; set; }
    }
}
