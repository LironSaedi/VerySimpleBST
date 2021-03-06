using System;
using System.Collections.Generic;

// loop while we have something in our stack
// loop all the way left
// push left nodes along the way
// collect value
// pop
// collect
// go right once
// start over (inner loop)
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
    static List<int> InOrderTraversal(BSTNode root, List<int> result)
    {
        Stack<BSTNode> stack = new Stack<BSTNode>();
        BSTNode holder = root;
        do
        {
            if (holder != null)
            {
                stack.Push(holder);
                holder = holder.Left;
            }
            else
            {
                holder = stack.Pop();
                result.Add(holder.Value);
                holder = holder.Right;
            }
        } while (stack.Count != 0);

        return result;
    }


    static List<int> PreOrderTraversal(BSTNode root, List<int> result)
    {
        Stack<BSTNode> stack = new Stack<BSTNode>();
        BSTNode holder = root;

        stack.Push(root);

        while (stack.Count != 0)
        {
            holder = stack.Pop();

            result.Add(holder.Value);

            if (holder.Right != null)
            {
                stack.Push(holder.Right);
            }

            if (holder.Left != null)
            {
                stack.Push(holder.Left);
            }



        }

        return result;
    }

    static void PreOrderTraversalRecursive(BSTNode node, List<int> result)
    {
        if (node == null) return;

        result.Add(node.Value);

        PreOrderTraversalRecursive(node.Left, result);

        PreOrderTraversalRecursive(node.Right, result);

    }

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
        //Add(root, root.Value);
        Console.WriteLine(root.Value);
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            int value = random.Next(1, 100);
            Console.WriteLine(value);
            Add(root, value);
            // Add(root, i);
        }



        List<int> result = new List<int>();
        //InOrderTraversal(root, result);
        PreOrderTraversal(root, result);
        Console.WriteLine("");

        Console.WriteLine("");
        Console.WriteLine("");
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }


        ;
    }
}