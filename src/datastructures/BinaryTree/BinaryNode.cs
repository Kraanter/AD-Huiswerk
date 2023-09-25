using System;

namespace AD
{
    public partial class BinaryNode<T> : IBinaryNode<T>
    {
        public T data;
        public BinaryNode<T> left;
        public BinaryNode<T> right;

        public BinaryNode() : this(default(T), default(BinaryNode<T>), default(BinaryNode<T>)) { }

        public BinaryNode(T data, BinaryNode<T> left, BinaryNode<T> right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------
        public T GetData()
        {
            return data;
        }

        public BinaryNode<T> GetLeft()
        {
            return left;
        }

        public BinaryNode<T> GetRight()
        {
            return right;
        }
        
        //----------------------------------------------------------------------
        // Own additions to make things work
        //----------------------------------------------------------------------
        public int Size()
        {
            int size = 0;
            
            if (left is not null)
                size += 1 + left.Size();
            
            if (right is not null)
                size += 1 + right.Size();

            return size;
        }

        public int Height()
        {
            int lheight = left?.Height() ?? -1;
            int rheight = right?.Height() ?? -1;

            return 1 + Math.Max(lheight, rheight);
        }

        public string ToPrefixString()
        {
            string retString = "[ ";
            retString += data;
            retString += " ";
            retString += left?.ToPrefixString() ?? "NIL";
            retString += " ";
            retString += right?.ToPrefixString() ?? "NIL";
            retString += " ]";
            return retString;
        }

        public string ToInfixString()
        {
            string retString = "[ ";
            retString += left?.ToInfixString() ?? "NIL";
            retString += " ";
            retString += data;
            retString += " ";
            retString += right?.ToInfixString() ?? "NIL";
            retString += " ]";
            return retString;
        }

        public string ToPostfixString()
        {
            
            string retString = "[ ";
            retString += left?.ToPostfixString() ?? "NIL";
            retString += " ";
            retString += right?.ToPostfixString() ?? "NIL";
            retString += " ";
            retString += data;
            retString += " ]";
            return retString;
        }

        public int NumberOfLeaves()
        {
            if (left is null && right is null)
                return 1;
            
            int lNumOfLeaves = left?.NumberOfLeaves() ?? 0;
            int rNumOfLeaves = right?.NumberOfLeaves() ?? 0;

            return lNumOfLeaves + rNumOfLeaves;
        }

        public int NumberOfNodesWithOneChild()
        {
            if ((left is not null && right is null) || (right is not null && left is null))
                return 1;

            int lNumOfNodes = left?.NumberOfNodesWithOneChild() ?? 0;
            int rNumOfNodes = right?.NumberOfNodesWithOneChild() ?? 0;

            return lNumOfNodes + rNumOfNodes;
        }

        public int NumberOfNodesWithTwoChildren()
        {
            int numOfNodes = 0;
            if (left is not null && right is not null)
                numOfNodes += 1;
            
            numOfNodes += left?.NumberOfNodesWithTwoChildren() ?? 0;
            numOfNodes += right?.NumberOfNodesWithTwoChildren() ?? 0;

            return numOfNodes;
        }
    }
}