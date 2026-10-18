List<(string Val, int Priority)> queues = [];

void Enqueue(string val, int priority)
{
    queues.Add((val, priority));
    queues.Sort((a, b) => b.Priority.CompareTo(a.Priority));
    Console.WriteLine($"Queued {val} with priority {priority}");
}

void Process()
{
    if (queues.Count > 0)
    {
        Console.WriteLine($"Processed {queues[0].Val}");
        queues.RemoveAt(0);
    }
    else
    {
        Console.WriteLine("Queue is empty");
    }
}

Enqueue("A", 1);
Enqueue("B", 5);
Enqueue("C", 5);
Process();
Process();
Process();