using System;
using System.Net.Sockets;

namespace AD
{
    public partial class FirstChildNextSibling<T> : IFirstChildNextSibling<T>
    {
        public FirstChildNextSiblingNode<T> root;

        public IFirstChildNextSiblingNode<T> GetRoot()
        {
            return root;
        }

        public int Size()
        {
            if (root is null)
                return 0;
            
            return 1 + root.Size();
        }

        public void PrintPreOrder()
        {
            Console.WriteLine("KAASSTENGELS");
        }

        public override string ToString()
        {
            if (root is null)
                return "NIL";

            return root.ToString();
        }

    }
}