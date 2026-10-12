Queue<string> queues = new();
Queue<string> vipQueues = new();

void Enqueue(string val)
{
    queues.Enqueue(val);
    System.Console.WriteLine($"Queued {val}");
}

void EnqueueVip(string val)
{
    vipQueues.Enqueue(val);
    System.Console.WriteLine($"VIP Queued {val}");
}

void Process()
{
    if (vipQueues.Count() > 0)
    {
        System.Console.WriteLine($"Processed {vipQueues.Dequeue()}");
    }
    else if (queues.Count() > 0)
    {
        System.Console.WriteLine($"Processed {queues.Dequeue()}");
    }
    else
    {
        System.Console.WriteLine("Queue is empty");
    }
}

Enqueue("A");
Enqueue("B");
EnqueueVip("C");
Process();
Process();
Process();