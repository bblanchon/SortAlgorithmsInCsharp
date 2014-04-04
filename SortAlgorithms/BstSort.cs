using System;
using System.Collections.Generic;

namespace SortAlgorithms
{
    public class BstSort<T> : SortAlgorithm<T>
        where T : IComparable<T>
    {
        public override void Sort(T[] array)
        {
            var bst = new Bst();

            foreach (var value in array)
            {
                bst.Add(value);
            }

            var index = 0;
            foreach (var value in bst.WalkInOrder())
            {
                array[index++] = value;
            }
        }

        class Node
        {
            public Node(T value)
            {
                Value = value;
            }

            public T Value { get; private set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }

        class Bst
        {
            Node root;

            public void Add(T value)
            {
                var node = new Node(value);
                root = AddNodeInSubTree(root, node);
            }

            public IEnumerable<T> WalkInOrder()
            {
                return WalkSubTree(root);
            }

            IEnumerable<T> WalkSubTree(Node subtree)
            {
                if (subtree == null)
                    yield break;

                foreach (var value in WalkSubTree(subtree.Left))
                    yield return value;

                yield return subtree.Value;

                foreach (var value in WalkSubTree(subtree.Right))
                    yield return value;
            }

            static Node AddNodeInSubTree(Node subtree, Node node)
            {
                if (subtree == null)
                    return node;

                if (node.Value.CompareTo(subtree.Value) < 0)
                {
                    subtree.Left = AddNodeInSubTree(subtree.Left, node);
                }
                else
                {
                    subtree.Right = AddNodeInSubTree(subtree.Right, node);
                }

                return subtree;
            }
        }
    }
}
