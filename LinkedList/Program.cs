using System.Text;

LinkedList<int> linkedValues = new();

void Append(int val)
{
    linkedValues.AddLast(val);
    System.Console.WriteLine($"Appended {val}");
}

void Print()
{
    LinkedListNode<int>? current = linkedValues.First;
    StringBuilder text = new StringBuilder("Sequence: ");
    text.Append($"{current?.Value}");
    while (current?.Next != null)
    {
        current = current.Next;
        text.Append($" -> {current.Value}");
    }
    System.Console.WriteLine(text.ToString());
}

void PrintReverse()
{
    LinkedListNode<int>? current = linkedValues.Last;
    StringBuilder text = new StringBuilder("Reverse: ");
    text.Append($"{current?.Value}");
    while (current?.Previous != null)
    {
        current = current.Previous;
        text.Append($" -> {current.Value}");
    }
    System.Console.WriteLine(text.ToString());
}

Append(5);
Append(10);
Append(15);
// LinkedListNode<int>? current = linkedValues.Find(10);
// linkedValues.AddBefore(current, 8);
Print();
PrintReverse();
