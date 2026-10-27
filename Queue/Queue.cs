
public class Queue
{
    private List<(string Val, int Priority)> queues = [];
    private Dictionary<string, int> queueRules = new();

    public void AddRule(string keyword, int priority)
    {
        queueRules[keyword] = priority;
    }

    public void Enqueue(string val)
    {
        int priority = queueRules.TryGetValue(val, out priority) ? priority : 0;
        queues.Add((val, priority));
        queues.Sort((a, b) => b.Priority.CompareTo(a.Priority));
        Console.WriteLine($"Queued {val} with priority {priority}");
    }

    public void Process()
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
}
