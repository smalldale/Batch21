using System.Text;

LinkedList<int> linkedValues = new();

void Append(int val)
{
    LinkedListNode<int>? current = linkedValues.First;
    while (current != null && current.Value < val)
    {
        current = current.Next;
    }
    if (current == null)
    {
        linkedValues.AddLast(val);
    }
    else
    {
        linkedValues.AddBefore(current, val);
    }
    Console.WriteLine($"Appended {val}");
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
    Console.WriteLine(text.ToString());
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
    Console.WriteLine(text.ToString());
}

Append(5);
Append(2);
Append(8);
Print();
PrintReverse();
