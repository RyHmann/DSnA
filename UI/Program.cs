using DataStructures;

var testList = new SinglyLinkedList();
var numArray = new int[] { 7, 9, 3, 1, 5, 9, 10, 153, 989, 13, 498, 16 };

testList.Head = new SNode(5);


testList.AddNode(7);
testList.AddNode(21);
testList.AddNode(2);
testList.AddNode(965);
testList.AddNode(1);
testList.AddNode(400);

PrintAllNodes(testList);

//Delete '2' at index 3
testList.DeleteNode(3);
PrintAllNodes(testList);

testList.DeleteNode(3);
PrintAllNodes(testList);



static void PrintLastNode(SinglyLinkedList list)
{
    var currentNode = list.Head;

    while (currentNode.Next != null)
    {
        currentNode = currentNode.Next;
    }

    Console.WriteLine(currentNode.Value);
}

static void PrintAllNodes(SinglyLinkedList list)
{
    Console.WriteLine(String.Empty);
    var currentNode = list.Head;
    Console.Write($"{currentNode.Value}" + ',');
    while (currentNode.Next != null)
    {
        currentNode = currentNode.Next;
        Console.Write($"{currentNode.Value}" + ',');
    }
}


