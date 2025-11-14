SomeConfig someConfig = new();
someConfig.Root = new(1);
someConfig.Root.Child = new(2);
someConfig.Root.Child.Child = new(3);
someConfig.Root.Child.Child.Child = new(4);

// if (someConfig is SomeConfig sc)
// {
//     if (sc.Root is Node root)
//     {
//         if (root.Child is Node node1)
//         {
//             if (node1.Child is Node node2)
//             {
//                 if (node2.Child is Node node3)
//                 {
//                     Console.WriteLine(node3.Value);
//                 }   
//             }
//         }
//     }
// }

Console.WriteLine(someConfig.Root?.Child?.Child?.Child?.Value);

class SomeConfig
{
    public Node? Root { get; set; }
}

class Node
{
    public Node(int value)
    {
        Value = value;
    }

    public Node? Child { get; set; }

    public int Value { get; set; }
}