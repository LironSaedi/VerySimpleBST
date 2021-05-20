using System;

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

        

        if (temp.Value > value)
        {
            //left side
            while(temp.Value > value)
            {
                //WHAT WE HAVE TO DO. fIND THE PLACE WHERE THE VALUE GOES BY INCRETING TEMP = TEMP.rIGHT
            }
                    
        }

        if (temp.Value < value)
        {
            //right side
        }

        if(temp.Value == value)
        {
            //duplicate
        }
        if (temp.Right == null)
            if (value > root.Value)
            {
                root.Right.Value = value;
            }

        if (value < root.Value)
        {
            root.Left.Value = value;
        }

    }

    static void Main()
    {
        BSTNode root = new BSTNode() { Value = 42 };

        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            int value = random.Next(1, 100);
            Console.WriteLine(value);
            Add(bst, value);
        }

        ;
    }
}