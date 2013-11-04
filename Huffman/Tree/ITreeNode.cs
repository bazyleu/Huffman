using System;

namespace Huffman.Tree
{
    interface ITreeNode
    {
        ITreeNode Left { get; set; }
        ITreeNode Rigth { get; set; }
        Byte Value { get; set; }
    }
}
