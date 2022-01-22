using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Node<N> where N : IComparable<N>
    {
        public N val { get; set; }
        public int Rcount = 0;

        private Node<N> left = null;
        private Node<N> right = null;

        public Node()
        {
            val = default;
        }
        public Node(N value)
        {
            val = value;
        }
        public void Add(N value)
        {
            if(val.CompareTo(value)<0)
            {
                if (left == null)
                {
                    left = new Node<N>(value);
                    Rcount++;
                }
                else
                {
                    left.Add(value);
                    Rcount++;
                }
            }
            else
            {
                if (right == null)
                {
                    right = new Node<N>(value);
                    Rcount++;
                }
                else
                {
                    right.Add(value);
                    Rcount++;
                }
            }
        }
        public void DisplayNode(string offset)
        {
            Console.Write(offset);
            Console.WriteLine(ToString());
            if (right != null)
                right.DisplayNode(offset + '\t');
            else
                Console.WriteLine(offset + "(null)");
            if (left != null)
                left.DisplayNode(offset + '\t');
            else
                Console.WriteLine(offset + "(null)");
            Console.WriteLine();

        }
        public override string ToString()
        {
            if (val != null)
                return val.ToString();
            return "null";
        }
    }
}
