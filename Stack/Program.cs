int n = 3;
Stack<string> stack = new();
Stack<string> redoStack = new();

void Type(string word)
{
    if (stack.Count + 1 > n)
    {
        stack = new(stack.ToArray()[..(n-1)].Reverse());
        Console.Write("Dropped bottom, ");
    }
    stack.Push(word);
    redoStack.Clear();
    Console.Write($"Typed {stack.Peek()}\n");
}

void Undo()
{
    if (stack.Count > 0)
    {
        string redoWord = stack.Pop();
        redoStack.Push(redoWord);
        Console.WriteLine($"Undid {redoWord}");
    }
}

void Redo()
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

Type("A");
Type("B");
Undo();
Redo();
Type("C");
Undo();
Type("D");
Redo();
Undo();
Undo();
Undo();
