static void Generate(int count)
    {
        for (int i = 1; i <= count; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                System.Console.Write("foobar");
            }
            else if (i % 3 == 0)
            {
                System.Console.Write("foo");
            }
            else if (i % 5 == 0)
            {
                System.Console.Write("bar");
            }
            else
            {
                System.Console.Write(i);
            }
            if (i < count)
            {
                System.Console.Write(", ");
            }
        }
    } 

Generate(15);
