namespace CSharpChallenges.Infrastructure.ExampleChallenges
{
    /// <summary> Binary Search Tree:  </summary>
    public class BinarySearchTree
    {
        public bool Contains(Node root, int value)
        {
            if ( root == null) {
                return false; 
            }
            else if ( value == root.Value ) {
                return true; 
            }
            else if ( value < root.Value ) {
                return Contains(root.Left, value);
            }
            else if ( value > root.Value ) {
                return Contains(root.Right, value);
            }
            else {
                return false;
            }
        }
    }

    public class Node {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value, Node left, Node right) {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}