LinkedList<int> linkedValues = new();

void Append(int val)
{
    linkedValues.AddLast(val);
}

void Print()
{
     LinkedListNode<int>? current = linkedValues.First;
     System.Console.Write(current?.Value);
     while (current?.Next != null)
     {
        current = current.Next;
        System.Console.Write($" -> {current.Value}");
     }

}

Append(5);
Append(10);
Print();
