namespace CSharpChallenges.Infrastructure.ExampleChallenges
{
    /// <summary> Binary Search Tree:  </summary>
    public class BinarySearchTree
    {
        public string TreeConstructor(string[] strArr) {
            var childs = strArr.ToList().Select(i => i.Split(',')[0].Replace("(", string.Empty)).ToList();
            var parents = strArr.ToList().Select(i => i.Split(',')[1].Replace(")", string.Empty)).ToList();
            return childs.Distinct().Count() == strArr.Count() && 
                !parents.GroupBy(p => p).Where(g => g.Count() > 2).Any() ? "true" : "false";
        }

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