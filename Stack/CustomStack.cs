public class CustomStack
{
    private int n = 3;
    private Stack<string> stack = new();
    private Stack<string> redoStack = new();
    List<Func<string, bool>> validationRules = [];

    public void Type(string word)
    {
        foreach (Func<string, bool> rule in validationRules)
        {
            if (!rule(word))
            {
                Console.WriteLine("Rejected");
                return;
            }
        }

        if (stack.Count + 1 > n)
        {
            stack = new(stack.ToArray()[..(n-1)].Reverse());
            Console.Write("Dropped bottom, ");
        }
        stack.Push(word);
        redoStack.Clear();
        Console.Write($"Typed {stack.Peek()}\n");
    }

    public void Undo()
    {
        if (stack.Count > 0)
        {
            string redoWord = stack.Pop();
            redoStack.Push(redoWord);
            Console.WriteLine($"Undid {redoWord}");
        }
    }

    public void Redo()
    {
        if (redoStack.Count > 0)
        {
            stack.Push(redoStack.Pop());
            Console.Write($"Redid {stack.Peek()}\n");
        }
        else
        {
            Console.WriteLine("Empty Redo Stack.");
        }
    }

    public void AddValidationRule(Func<string, bool> rule)
    {
        validationRules.Add(rule);
    }
}