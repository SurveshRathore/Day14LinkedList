
using Day14LinkedList;
Console.WriteLine(" ---------- UC 1 simple Linked List ----------");
UC1SimpleLinkedList ll = new UC1SimpleLinkedList();
ll.Add(56);
ll.Add(30);
ll.Add(70);
ll.Display();

Console.WriteLine("\n ---------- UC 2 Reverse Linked List ----------");
UC2AddNode uc2Add = new();
uc2Add.Add(70);
uc2Add.Add(30);
uc2Add.Add(56);
uc2Add.Display();

Console.WriteLine("\n ---------- UC 3 Append Linked List ----------");
UC3AppendNode uc3Append = new();
uc3Append.Append(56);
uc3Append.Append(30);
uc3Append.Append(70);
uc3Append.Display();

Console.WriteLine("\n ---------- UC 4 Insert in Linked List ----------");
UC4InsertNode uc4Insert = new();
uc4Insert.Add(56);
uc4Insert.Add(70);
uc4Insert.InsertBetween(56, 30);
uc4Insert.Display();

Console.WriteLine("\n ---------- UC 5 Delete First element in the Linked List ----------");
UC5RemoveFirstNode uc5removefirst = new();
uc5removefirst.Add(56);
uc5removefirst.Add(30);
uc5removefirst.Add(70);
uc5removefirst.pop();
uc5removefirst.Display();

Console.WriteLine("\n ---------- UC 6 Delete Last element in the Linked List ----------");
UC6Remove_LastElement uc6removeLast = new();
uc6removeLast.Add(56);
uc6removeLast.Add(30);
uc6removeLast.Add(70);
uc6removeLast.popLast();
uc6removeLast.Display();

Console.WriteLine("\n ---------- UC 7 Search node in the Linked List ----------");
UC7SearchNode uc7search = new();
uc7search.Add(56);
uc7search.Add(30);
uc7search.Add(70);
uc7search.Display();
uc7search.Search(30);
uc7search.Search(390);

Console.WriteLine("\n ---------- UC 8 Insert node in the Linked List ----------");
UC8InsertBetween uc8InsertBetween = new();
uc8InsertBetween.Add(56);
uc8InsertBetween.Add(30);
uc8InsertBetween.Add(70);
uc8InsertBetween.InsertBetween(30, 40);
uc8InsertBetween.Display();

Console.WriteLine("\n ---------- UC 9 Delete node from the Linked List And display the size ----------");
UC9DeleteNode uc9delNode = new();
uc9delNode.Add(56);
uc9delNode.Add(30);
uc9delNode.Add(40);
uc9delNode.Add(70);
uc9delNode.Size();
uc9delNode.Display();
uc9delNode.DeleteNode(40);
uc9delNode.Size();
uc9delNode.Display();

UC10SortedLinkedList sorted = new();


