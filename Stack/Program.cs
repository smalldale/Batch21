Stack<string> stack = new();

void Type(string word)
{
    stack.Push(word);
    System.Console.WriteLine($"Typed {stack.Peek()}");
}

void Undo()
{
    if (stack.Count > 0)
    {
        System.Console.WriteLine($"Undid {stack.Pop()}");
    }
}

Type("foo");
Type("bar");
Undo();
Undo();
