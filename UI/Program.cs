using DataStructures;
using LeetCode;


int[] twoSumArgs = new int[] { 1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1 };
var twoSum = new TwoSum(twoSumArgs);
int target = 11;


var twoSumSolution = twoSum.TwoSumNSquared(twoSumArgs, target);
var twoSumOptimal = new TwoSum(twoSumArgs);
var twoSumSolutionOptimal = twoSumOptimal.TwoSumSolution(twoSumArgs, target);

foreach (int i in twoSumSolutionOptimal)
{
    Console.Write($"{i} ");
}
//var testList = new SinglyLinkedList();
//var numArray = new int[] { 7, 9, 3, 1, 5, 9, 10, 153, 989, 13, 498, 16 };

//testList.Head = new SNode(5);


//testList.AddNode(7);
//testList.AddNode(21);
//testList.AddNode(2);
//testList.AddNode(965);
//testList.AddNode(1);
//testList.AddNode(400);

//PrintAllNodes(testList);

//var searchInt = 1;
//var index = testList.FindValue(searchInt);
//Console.WriteLine($"Index of '{searchInt}' is '{index}'");


//testList.DeleteNode(5);
//Console.WriteLine($"Deleting number at index '{index}'");
//PrintAllNodes(testList);

//static void PrintLastNode(SinglyLinkedList list)
//{
//    var currentNode = list.Head;

//    while (currentNode.Next != null)
//    {
//        currentNode = currentNode.Next;
//    }

//    Console.WriteLine(currentNode.Value);
//}

//static void PrintAllNodes(SinglyLinkedList list)
//{
//    Console.WriteLine(String.Empty);
//    var currentNode = list.Head;
//    Console.Write($"{currentNode.Value}" + ',');
//    while (currentNode.Next != null)
//    {
//        currentNode = currentNode.Next;
//        Console.Write($"{currentNode.Value}" + ',');
//    }
//    Console.WriteLine(String.Empty);
//}


