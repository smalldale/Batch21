using System.Text;

public class CustomLinkedList
{
    private LinkedList<int> _linkedValues = new();

    private Func<int, int, int>? _sorting;
    private List<Func<int, bool>> _filterRules = [];

    public void Append(int val)
    {
        _linkedValues.AddLast(val);
        Console.WriteLine($"Appended {val}");
    }

    private LinkedList<int> SortedLinkedList()
    {
        if (_sorting != null)
        {
            List<int> tempList = [];
            foreach (var val in _linkedValues)
            {
                if (PassesFilters(val))
                {
                    tempList.Add(val);
                }
            }
            tempList.Sort((a, b) => _sorting(a, b));
            tempList.Reverse();
            return new LinkedList<int>(tempList);
        }
        return _linkedValues;
    }

    private bool PassesFilters(int val)
    {
        foreach (var rule in _filterRules)
        {
            if (!rule(val))
            {
                return false;    
            } 
        }
        return true;
    }

    public void Print()
    {
        LinkedListNode<int>? current = SortedLinkedList().First;
        StringBuilder text = new StringBuilder("Sequence: ");
        text.Append($"{current?.Value}");
        while (current?.Next != null)
        {
            current = current.Next;
            text.Append($" -> {current.Value}");
        }
        Console.WriteLine(text.ToString());
    }

    public void PrintReverse()
    {
        LinkedListNode<int>? current = SortedLinkedList().Last;
        StringBuilder text = new StringBuilder("Reverse: ");
        text.Append($"{current?.Value}");
        while (current?.Previous != null)
        {
            current = current.Previous;
            text.Append($" -> {current.Value}");
        }
        Console.WriteLine(text.ToString());
    }

    public void SetSorting(Func<int, int, int> comparer)
    {
        _sorting = comparer;
    }

    public void AddFilter(Func<int, bool> filterRule)
    {
        _filterRules.Add(filterRule);
    }
}