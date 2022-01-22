using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class BinaryTree<N> where N : IComparable<N>
    {
        private Node<N> root = null;
        public int count = 0;

        public void Add(N value)
        {
            if (root == null)
                root = new Node<N>(value);
            else
                root.Add(value);
        }
        public void Display()
        {
            if (root != null)
                root.DisplayNode("");
            else
                Console.WriteLine("empty tree");
        }
        public void Search(int count)
        {
            for (count = 0; count < 0; count ++);
        }
    }
}
