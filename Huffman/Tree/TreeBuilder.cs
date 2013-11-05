
namespace Huffman.Tree
{
    public class TreeBuilder
    {
        public ITreeNode BuildTree(TreeBuilderQueue queue)
        {
            while (queue.Count > 1)
            {
                queue.Push(MergeQueueItem(queue.Pull(), queue.Pull()));
            }

            return queue.Pull().TreeNode;
        }

        private QueueItem MergeQueueItem(QueueItem item1, QueueItem item2)
        {
            TreeNode treeNode = new TreeNode(item1.TreeNode, item2.TreeNode);

            QueueItem queuItem = new QueueItem(treeNode, item1.Priority + item2.Priority);
            return queuItem;
        }
    }
}
