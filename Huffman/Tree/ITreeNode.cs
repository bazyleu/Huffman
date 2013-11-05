using System;

namespace Huffman.Tree
{
    public interface ITreeNode
    {
        ITreeNode Left { get; set; }
        ITreeNode Rigth { get; set; }
        byte? Value { get; set; }
    }
}
