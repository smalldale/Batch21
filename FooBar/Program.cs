using System.Text;

static void Generate(int count)
    {
        for (int i = 1; i <= count; i++)
        {
            StringBuilder text = new StringBuilder();
            if (i % 3 == 0)
            {
                text.Append("foo");
            }
            if (i % 5 == 0)
            {
                text.Append("bar");
            }
            if (i % 7 == 0)
            {
                text.Append("jazz");
            }
            if (text.ToString() == "")
            {
                text.Append($"{i}");
            }
            System.Console.Write(text.ToString());
            if (i < count)
            {
                System.Console.Write(", ");
            }
        }
    } 

Generate(105);
