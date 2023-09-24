using System.Text;

namespace AD
{
    public partial class FirstChildNextSiblingNode<T> : IFirstChildNextSiblingNode<T>
    {
        public FirstChildNextSiblingNode<T> firstChild;
        public FirstChildNextSiblingNode<T> nextSibling;
        public T data;

        public FirstChildNextSiblingNode(T data, FirstChildNextSiblingNode<T> firstChild, FirstChildNextSiblingNode<T> nextSibling)
        {
            this.data = data;
            this.firstChild = firstChild;
            this.nextSibling = nextSibling;
        }

        public FirstChildNextSiblingNode(T data)
        {
            this.data = data;
        }

        public T GetData()
        {
            return data;
        }

        public FirstChildNextSiblingNode<T> GetFirstChild()
        {
            return firstChild;
        }

        public FirstChildNextSiblingNode<T> GetNextSibling()
        {
            return nextSibling;
        }

        public int Size()
        {
            int height = 0;
            
            if (firstChild is not null)
                height += 1 + firstChild.Size();
            
            if (nextSibling is not null)
                height += 1 + nextSibling.Size();

            return height;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            
            sb.Append(data);
            
            if (firstChild is not null)
                sb.Append($",FC({firstChild})");

            if (nextSibling is not null)
                sb.Append($",NS({nextSibling})");

            return sb.ToString();
        }
    }
}