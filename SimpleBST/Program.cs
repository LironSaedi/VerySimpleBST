using System;
using System.Collections.Generic;

class BSTNode
{
    public int Value { get; set; }
    public BSTNode Left { get; set; }
    public BSTNode Right { get; set; }
}

class Program
{
    static void Add(BSTNode root, int value)
    {
        BSTNode temp = root;

        while (temp != null)
        {
            if (value < temp.Value) // check wehter to go left or right by seeing if it is greater than or less than the roor
            {
                if (temp.Left == null) // if this is null then that means taht they is no value there
                {
                    BSTNode holder = new BSTNode();
                    holder.Value = value;
                    temp.Left = holder;
                    break;
                }
                temp = temp.Left;
            }
            else
            {
                if (temp.Right == null)
                {

                    BSTNode holder = new BSTNode();
                    holder.Value = value;
                    temp.Right = holder;
                    break;
                }
                temp = temp.Right;// move on to next value
            }

        }
    }

    // TODO
    static List<int> InOrderTraversal(BSTNode root)
    {
        List<int> result = new List<int>();

        // TODO: fill the list with values from the BST, in order
        Stack<int> stack = new Stack<int>();


        return result;
    }




    // Figure out how this works
    static void traverseRecursive(BSTNode node, List<int> result)
    {
        if (node == null) return;

        traverseRecursive(node.Left, result);

        result.Add(node.Value);

        traverseRecursive(node.Right, result);
    }


    static void Main()
    {
        BSTNode root = new BSTNode() { Value = 42 };

        Random random = new Random();
        for (int i = 0; i < 2000; i++)
        {
            //int value = random.Next(1, 100);
            //Console.WriteLine(value);
            //Add(root, value);
            Add(root, i);
        }

        var result = new List<int>();
        traverseRecursive(root, result);
        ;
    }
}