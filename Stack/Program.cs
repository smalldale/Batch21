int n = 3;
Stack<string> stack = new();

void Type(string word)
{
    if (stack.Count + 1 > n)
    {
        stack = new(stack.ToArray()[..(n-1)].Reverse());
        System.Console.Write("Dropped bottom, ");
    }
    stack.Push(word);
    System.Console.Write($"Typed {stack.Peek()}\n");
}

void Undo()
{
    if (stack.Count > 0)
    {
        System.Console.WriteLine($"Undid {stack.Pop()}");
    }
}

Type("A");
Type("B");
Type("C");
Type("D");
Undo();
Undo();
Undo();
Undo();
