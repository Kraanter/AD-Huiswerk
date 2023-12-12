using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD
{
    public class FirstChildNextSiblingSorter
    {
        public FirstChildNextSibling<int> tree;

        public FirstChildNextSiblingSorter()
        {
            Init();
        }

        public void Init()
        {
            tree = new FirstChildNextSibling<int>();
            tree.root = new FirstChildNextSiblingNode<int>(Int32.MaxValue);
        }

        public void VoegToe(int getal)
        {
            VoegToe(getal, tree.root);
        }

        private void VoegToe(int getal, FirstChildNextSiblingNode<int> POK)
        {
            // LET OP DEZE FUNCTIE DOET HET NIET ZOALS HIJ HOORT TE WERKEN
            // DEZE FUNCTIE GAAT MIS MET DE INPUT: 5, 3, 4, 2
            var NK = new FirstChildNextSiblingNode<int>(getal);

            if (POK?.GetFirstChild() is null)
                POK.firstChild = NK;
            else
            {
                var node = POK.GetFirstChild();
                FirstChildNextSiblingNode<int> small = null;
                while (node?.GetNextSibling() is not null)
                {
                    node = node.GetNextSibling();
                    if (small is null && node.data > NK.data)
                        small = node;
                }

                if (node.GetData() <= NK.data)
                    node.nextSibling = NK;
                else 
                    VoegToe(getal, small ?? POK.GetFirstChild());
            }
        }

        public void Sorteer(ref List<int> getallen)
        {
            Init();

            foreach (var getal in getallen)  
                VoegToe(getal);

            var retList = new List<int>();

            var curNode = tree.root.firstChild;
            
            while (curNode is not null)
            {
                Sort(curNode, retList);
                curNode = curNode.nextSibling;
            }

            getallen = retList;
        }

        public void Sort(FirstChildNextSiblingNode<int> node, List<int> getallen)
        {
            var child = node.firstChild;
            while (child is not null)
            {
                Sort(child, getallen);
                child = child.nextSibling;
            }
            getallen.Add(node.data);
        }

        private static void ForAllChildren(FirstChildNextSiblingNode<int> node, Action<FirstChildNextSiblingNode<int>> action)
        {
            var child = node.firstChild;
            while (child is not null)
            {
                action(child);
                child = child.nextSibling;
            }
        }
    }
}
