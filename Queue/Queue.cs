
public class Queue
{
    private List<(string Val, int Priority)> _queues = [];
    private Dictionary<string, int> _queueRules = new();

    public void AddRule(string keyword, int priority)
    {
        _queueRules[keyword] = priority;
    }

    public void Enqueue(string val)
    {
        int priority = _queueRules.TryGetValue(val, out priority) ? priority : 0;
        _queues.Add((val, priority));
        _queues.Sort((a, b) => b.Priority.CompareTo(a.Priority));
        Console.WriteLine($"Queued {val} with priority {priority}");
    }

    public void Process()
    {
        if (_queues.Count > 0)
        {
            Console.WriteLine($"Processed {_queues[0].Val}");
            _queues.RemoveAt(0);
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }
    }   
}
