Queue<string> queueList = new();

void Enqueued(string val)
{
    queueList.Enqueue(val);
    System.Console.WriteLine($"Queued {val}");
}

void Process()
{
    if (queueList.Count() > 0)
    {
        System.Console.WriteLine($"Processed {queueList.Dequeue()}");
    }
    else
    {
        System.Console.WriteLine("Queue is empty");
    }
}

Enqueued("A");
Enqueued("B");
Process();
Process();
Process();