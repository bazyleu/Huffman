using System;

namespace Huffman.Tree
{
    class TreeNode : ITreeNode
    {
        public TreeNode() { }

        public TreeNode(Byte value)
        {
            this.Value = value;
        }

        public ITreeNode Left { get; set; }
        public ITreeNode Rigth { get; set; }
        public Byte Value { get; set; }
    }
}
